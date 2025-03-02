using System;
using System.Configuration;
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
                txtIDCosmetico.Text = compraActual.IDCosmeticos.ToString();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra
            {
                FechaCompra = dtpFechaCompra.Value,
                TotalCompra = Convert.ToDouble(spTotalCompra.Text),
                MetodoPago = cbMetodoPago.Text,
                Proveedor = cbProveedor.Text,
                CantidadProductos = (int)numericUpDownCantidad.Value,
                EstadoCompra = cbEstado.Text,
                IDCosmeticos = Convert.ToInt32(txtIDCosmetico.Text)
            };

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

            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agregar_click(object sender, EventArgs e)
        {
            new VentanaGestionCompras().ShowDialog();
        }

        private void btn_salir(object sender, EventArgs e)
        {
            Close();
        }
    }
}
