using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ExamenGrupo5
{
    public partial class VentanaAgregarVenta : Form
    {

        private Venta _venta= null;
        private Conexion _conexion = null;
        private bool edita = false;
        
        public VentanaAgregarVenta()
        {
            InitializeComponent();
            edita = false;
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
        }

        public VentanaAgregarVenta(Venta venta)            
        {
            _venta = venta;
            InitializeComponent();
            edita = true;
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            cargarDatos(_venta);
            txtPrecioTotal.Text = (venta.CantidadVendido * _conexion.BuscarPorIdCosmetico(venta.IDCosmetico).PrecioUnitario).ToString();
        }

        private void CargarComboBoxCosmeticos()
        {
            try
            {
                
                DataSet dsCosmeticos = _conexion.CosmeticosId();

                cbIdCosmetico.DataSource = dsCosmeticos.Tables[0];
                cbIdCosmetico.DisplayMember = "IDCosmetico";  // Muestra los ID en el ComboBox
                cbIdCosmetico.ValueMember = "IDCosmetico"; // Guarda el ID como valor

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ID de los cosméticos: " + ex.Message);
            }
        }

        private void CargarComboBoxConsumidores()
        {
            try
            {
                
                DataSet dsConsumidores = _conexion.ObtenerIDConsumidores();

                cbIdConsumidor.DataSource = dsConsumidores.Tables[0];
                cbIdConsumidor.DisplayMember = "IdConsumidor";  // Muestra los ID en el ComboBox
                cbIdConsumidor.ValueMember = "IdConsumidor"; // Guarda el ID como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ID de los consumidores: " + ex.Message);
            }
        }

        private void GuardarDatos()
        {
            try {
                
                if (cbIdCosmetico.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un cosmético.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbIdConsumidor.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un consumidor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbMetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbEstadoVentas.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un estado para la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🛑 2️⃣ Obtener el cosmético desde la base de datos
                Cosmetico cosmetico = _conexion.BuscarPorIdCosmetico(int.Parse(cbIdCosmetico.SelectedValue.ToString()));

                if (cosmetico == null)
                {
                    MessageBox.Show("El cosmético seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double totalVenta = cosmetico.PrecioUnitario * int.Parse(pkCantidadVendidos.Value.ToString());

                if (cosmetico.StockDisponible < int.Parse(pkCantidadVendidos.Value.ToString()))
                {
                    MessageBox.Show($"No se cuenta actualmente con la cantidad suficiente de productos para suplir con la venta. Ingrese un numero de productos menor a {cosmetico.StockDisponible}");
                }

                var venta = new Venta
                {
                     // Asumiendo que tienes un TextBox llamado txtIdVenta
                    FechaVenta = dtpFechaVenta.Value, // DateTimePicker para seleccionar la fecha
                    TotalVenta = totalVenta, // TextBox para el total de la venta
                    MetodoPago = cbMetodoPago.SelectedItem.ToString(), // ComboBox con los métodos de pago
                    PuntosUsados = int.Parse(pkPuntosUsados.Value.ToString()), // TextBox para los puntos usados
                    CantidadVendido = (int)pkCantidadVendidos.Value, // TextBox para la cantidad vendida
                    IDCosmetico = int.Parse(cbIdCosmetico.SelectedValue.ToString()), // ComboBox con los IDs de cosméticos
                    IDConsumidor = int.Parse(cbIdConsumidor.SelectedValue.ToString()), // ComboBox con los IDs de consumidores
                    EstadoVenta = cbEstadoVentas.SelectedItem.ToString() // ComboBox con el estado de la venta
                };
                venta.IdVenta = 1;
                _conexion.GuardarVentas(venta);

                if(venta.EstadoVenta == "Completado")
                {
                    cosmetico.StockDisponible -= venta.CantidadVendido;
                    _conexion.ModificarCosmetico(cosmetico);
                }

                
                MessageBox.Show("Los cambios se han guardado correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void ActualizarDatos()
        {
            try
            {
                
                // Validar selección de cosmético
                if (cbIdCosmetico.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un cosmético.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar selección de consumidor
                if (cbIdConsumidor.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un consumidor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar selección de método de pago
                if (cbMetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar selección de estado de la venta
                if (cbEstadoVentas.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un estado para la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el cosmético desde la base de datos
                Cosmetico cosmetico = _conexion.BuscarPorIdCosmetico(int.Parse(cbIdCosmetico.SelectedValue.ToString()));

                if (cosmetico == null)
                {
                    MessageBox.Show("El cosmético seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcular el total de la venta
                double totalVenta = cosmetico.PrecioUnitario * (int)pkCantidadVendidos.Value;

                // Verificar disponibilidad del stock
                if (cosmetico.StockDisponible < (int)pkCantidadVendidos.Value)
                {
                    MessageBox.Show($"No hay suficiente stock. Disponible: {cosmetico.StockDisponible}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto de venta
                var venta = new Venta
                {
                    IdVenta = _venta.IdVenta,
                    FechaVenta = dtpFechaVenta.Value,
                    TotalVenta = totalVenta,
                    MetodoPago = cbMetodoPago.SelectedItem.ToString(),
                    PuntosUsados = (int)pkPuntosUsados.Value,
                    CantidadVendido = (int)pkCantidadVendidos.Value,
                    IDCosmetico = int.Parse(cbIdCosmetico.SelectedValue.ToString()),
                    IDConsumidor = int.Parse(cbIdConsumidor.SelectedValue.ToString()),
                    EstadoVenta = cbEstadoVentas.SelectedItem.ToString()
                };

                // Actualizar la venta en la base de datos
                _conexion.ModificarVenta(venta);

                // Actualizar el stock del cosmético si la venta está completada
                if (venta.EstadoVenta == "Completada")
                {
                    //cosmetico.StockDisponible -= venta.CantidadVendido;
                    //_conexion.ModificarCosmetico(cosmetico);
                }

                // Confirmación
                MessageBox.Show("Los cambios se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentanaAgregarVenta_Load(object sender, EventArgs e)
        {
            CargarComboBoxCosmeticos();
            CargarComboBoxConsumidores();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar(object sender, EventArgs e)
        {

            if (edita = false)
            {
                GuardarDatos();
            }
            else
            {
                ActualizarDatos();
            }
            

           
        }

        private void cargarDatos(Venta venta)
        {
            _conexion.MostrarIDVenta(venta.IdVenta);
            dtpFechaVenta.Value = venta.FechaVenta;
            pkCantidadVendidos.Value = venta.CantidadVendido;
            pkPuntosUsados.Value = venta.PuntosUsados;
            cbMetodoPago.SelectedItem = venta.MetodoPago;
            cbEstadoVentas.SelectedItem = venta.EstadoVenta;
            cbIdCosmetico.SelectedValue = venta.IDCosmetico;
            cbIdConsumidor.SelectedValue = venta.IDConsumidor;

        }


        private void pkCantidadVendidos_ValueChanged(object sender, EventArgs e)
        {
            if (cbIdCosmetico.SelectedValue != null) // Verificar que haya un cosmético seleccionado
            {
                // Buscar el cosmético por ID
                Cosmetico cosmetico = _conexion.BuscarPorIdCosmetico(int.Parse(cbIdCosmetico.SelectedValue.ToString()));

                // Calcular el total
                double totalVenta = cosmetico.PrecioUnitario * (int)pkCantidadVendidos.Value;

                // Mostrar en el TextBox (asumiendo que txtTotal es el nombre del TextBox)
                txtPrecioTotal.Text = totalVenta.ToString("0.00"); // Formatear con dos decimales
            }

        }

       

    }
}
