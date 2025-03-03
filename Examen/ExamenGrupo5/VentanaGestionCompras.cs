using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ExamenGrupo5
{
    public partial class VentanaGestionCompras : Form
    {
        private Conexion conexion;
        private Compra compraActual;

        public VentanaGestionCompras()
        {
            InitializeComponent();
            conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            
        }

        // Constructor para edición de compra
        public VentanaGestionCompras(Compra compra) : this()
        {
            compraActual = compra;
            CargarDatosCompra();
        }

        private void CargarComboBoxCosmeticos()
        {
            try
            {
                // Obtener los ID de los cosméticos desde la base de datos
                DataSet dsCosmeticos = conexion.CosmeticosId();

                // Asignar los datos al ComboBox
                cbIDCosmetico.DataSource = dsCosmeticos.Tables[0];
                cbIDCosmetico.DisplayMember = "IDCosmetico";  // Muestra los ID en el ComboBox
                cbIDCosmetico.ValueMember = "IDCosmetico";    // Guarda el ID como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ID de los cosméticos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarDatosCompra()
        {
            if (compraActual != null)
            {
                dtpFechaCompra.Value = compraActual.FechaCompra;
                spTotalCompra.Text = compraActual.TotalCompra.ToString();
                cbMetodoPago.Text = compraActual.MetodoPago;
                cbProveedor.Text = compraActual.Proveedor;
                numericUpDownCantidad.Value = compraActual.CantidadProductos;
                cbEstado.Text = compraActual.EstadoCompra;
                cbIDCosmetico.Text = compraActual.IDCosmeticos.ToString();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return; // Si la validación falla, detener el guardado

            try
            {
                Compra compra = new Compra
                {
                    FechaCompra = dtpFechaCompra.Value,
                    TotalCompra = Convert.ToDouble(spTotalCompra.Text),
                    MetodoPago = cbMetodoPago.Text,
                    Proveedor = cbProveedor.Text,
                    CantidadProductos = (int)numericUpDownCantidad.Value,
                    EstadoCompra = cbEstado.Text,
                    IDCosmeticos = Convert.ToInt32(cbIDCosmetico.Text)
                };

                Cosmetico cosmetico = conexion.BuscarPorIdCosmetico(compra.IDCosmeticos);

                if (compraActual == null)
                {
                    // Nueva compra
                    conexion.GuardarCompra(compra);
                    MessageBox.Show("Compra agregada correctamente.");
                }
                else
                {
                    // Actualizar compra existente
                    compra.IDCompra = compraActual.IDCompra;
                    conexion.ModificarCompra(compra);
                    MessageBox.Show("Compra actualizada correctamente.");
                }

                // 🔹 **Actualizar stock solo si la compra está "Completada"** 🔹
                if (compra.EstadoCompra == "Completada")
                {
                    cosmetico.StockDisponible += compra.CantidadProductos;
                    conexion.ModificarCosmetico(cosmetico);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private bool ValidarCampos()
        {
            List<string> mensajesError = new List<string>();

            // Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(spTotalCompra.Text))
                mensajesError.Add("El campo de total de compra no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(cbIDCosmetico.Text))
                mensajesError.Add("Debe ingresar un ID de cosmético.");

            // Validar que los ComboBox tengan una opción seleccionada
            if (cbMetodoPago.SelectedIndex == -1)
                mensajesError.Add("Por favor, seleccione un método de pago.");

            if (cbProveedor.SelectedIndex == -1)
                mensajesError.Add("Por favor, seleccione un proveedor.");

            if (cbEstado.SelectedIndex == -1)
                mensajesError.Add("Por favor, seleccione un estado de compra.");

            // Verificar que la cantidad de productos sea mayor a 0
            if (numericUpDownCantidad.Value <= 0)
                mensajesError.Add("La cantidad de productos debe ser mayor a 0.");

            // Si hay errores, mostrar un solo MessageBox con todos los errores
            if (mensajesError.Count > 0)
            {
                MessageBox.Show("Errores de validación:\n\n" + string.Join("\n", mensajesError),
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Indicar que la validación falló
            }

            return true; // Todo está correcto
        }



        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agregar_click(object sender, EventArgs e)
        {
            new VentanaGestionCompras().ShowDialog();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (cbIDCosmetico.SelectedValue != null && int.TryParse(cbIDCosmetico.SelectedValue.ToString(), out int idCosmetico))
            {
                // Buscar el cosmético por ID
                Cosmetico cosmetico = conexion.BuscarPorIdCosmetico(idCosmetico);

                // Verificar si el cosmético existe
                if (cosmetico == null)
                {
                    MessageBox.Show("No se encontró el cosmético seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la cantidad seleccionada
                int cantidadComprada = (int)numericUpDownCantidad.Value;

                // Calcular el total sin aplicar descuentos
                double totalCompra = cosmetico.PrecioUnitario * cantidadComprada;

                // Aplicar el 5% de descuento si se compran más de 100 unidades
                if (cantidadComprada > 100)
                {
                    totalCompra *= 0.95;
                }

                // Verificar que el valor calculado no exceda el rango del NumericUpDown
                if (totalCompra > (double)spTotalCompra.Maximum)
                {
                    MessageBox.Show("El total de la compra excede el límite permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar el total en el NumericUpDown
                spTotalCompra.Value = (decimal)totalCompra;
            }
        }


        private void btn_salir(object sender, EventArgs e)
        {
            Close();
        }

        private void VentanaGestionCompras_Load(object sender, EventArgs e)
        {
            CargarComboBoxCosmeticos();
        }
    }
}
