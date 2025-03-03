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
    public partial class VentanaVentas : Form
    {
        Conexion conexion;

        public VentanaVentas()
        {
            InitializeComponent();
            conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            cbEstadoVenta.SelectedIndex = 0; // Selecciona el primer ítem del combo box
            dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta("").Tables[0];
            ShowToolTipOnMouseUp(pictureBox1, "Actualizar");

        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowToolTipOnMouseUp(PictureBox pictureBox, string message)
        {
            ToolTip toolTip = new ToolTip();

            pictureBox.MouseUp += (sender, e) =>
            {
                toolTip.SetToolTip(pictureBox, message);
            };
        }

        private void EstadoVentaChanged(object sender, EventArgs e)
        {

            dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta(cbEstadoVenta.SelectedItem.ToString()).Tables[0];
        }

        private void Agregar_click(object sender, EventArgs e)
         {
            new VentanaAgregarVenta().ShowDialog();
            dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta("").Tables[0];

        }

        private void BuscarNombreCompra(object sender, EventArgs e)
        {

        }

        private void TbEditar(object sender, EventArgs e)
        {
            if (dtgTablaDatos.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas
            {
                DataGridViewRow filaSeleccionada = dtgTablaDatos.SelectedRows[0]; // Obtiene la primera fila seleccionada

                // Verifica si la celda "IdVenta" existe y no es nula
                if (filaSeleccionada.Cells["IdVenta"] != null && filaSeleccionada.Cells["IdVenta"].Value != DBNull.Value)
                {
                    int ID;
                    bool conversionExitosa = int.TryParse(filaSeleccionada.Cells["IdVenta"].Value.ToString(), out ID);

                    if (conversionExitosa)
                    {
                        Venta venta = conexion.MostrarIDVenta(ID);
                        venta.IdVenta = ID;
                        if (venta != null)
                        {
                            new VentanaAgregarVenta(venta).ShowDialog();
                            dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta("").Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Venta no encontrada.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID de la venta no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("La celda 'IdVenta' está vacía o no existe en la tabla.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }


        private void Eliminar(object sender, EventArgs e)
        {
            if (dtgTablaDatos.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta compra?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dtgTablaDatos.SelectedRows[0].Cells["IdVenta"].Value);
                    conexion.EliminarVenta(ID);
                    dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta(cbEstadoVenta.SelectedItem.ToString()).Tables[0];
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila entera para poder eliminar una compra.");
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // Implementar funcionalidad de impresión aquí
        }

        private void btnRefrescar(object sender, EventArgs e)
        {

        }
    }
}
