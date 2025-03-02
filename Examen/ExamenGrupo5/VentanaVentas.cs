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
            dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta("").Tables[0];

        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }

      
        private void EstadoVentaChanged(object sender, EventArgs e)
        {
            dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta(comboBox1.SelectedItem.ToString()).Tables[0];
        }

        private void Agregar_click(object sender, EventArgs e)
        {
            new VentanaAgregarVenta().ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(dtgDatos.SelectedRows[0].Cells["ID"].Value);
                if (ID > 0)
                {
                    Venta venta = conexion.MostrarIDVenta(ID);
                    if (venta != null)
                    {
                       // new VentanaAgregarCompra(ID).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("venta no encontrada.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID de la venta seleccionada no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila entera para poder editar una venta.");
            }
        }

        private void BuscarNombreCompra(object sender, EventArgs e)
        {

        }

        private void TbEditar(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                 int ID = Convert.ToInt32(dtgDatos.SelectedRows[0].Cells["ID"].Value);
               
                    Venta compra = conexion.MostrarIDVenta(ID);
                    if (compra != null)
                    {
                        //new VentanaAgregarCompra(compra).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Compra no encontrada.");
                    }
                
            }
            else
            {
                MessageBox.Show("Seleccione la fila entera para poder editar una compra.");
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (dtgTablaDatos.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(dtgTablaDatos.SelectedRows[0].Cells["IdVenta"].Value);
                
                    
                        conexion.EliminarVenta(ID);
                dtgTablaDatos.DataSource = conexion.BuscarPorEstadoVenta(comboBox1.SelectedItem.ToString()).Tables[0];
                return;
                    
                
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
    }
}
