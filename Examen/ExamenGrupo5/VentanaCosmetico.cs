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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenGrupo5
{
    public partial class VentanaCosmetico : Form
    {
        Conexion conexion;
        public VentanaCosmetico()
        {
            InitializeComponent();
            conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            dtgDatos.DataSource = conexion.BuscarPorNombreCosmeticos(txt_Nombre_Producto.Text).Tables[0];
        }

        private void Agregar_click(object sender, EventArgs e)
        {
            new VentanaAgregarCosmetico().ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                string nombre = dtgDatos.SelectedRows[0].Cells["Nombre"].Value?.ToString().Trim();
                if (!string.IsNullOrEmpty(nombre))
                {
                    Cosmetico cosmetico = conexion.BuscarPorNombreCosmetico(nombre);
                    if (cosmetico != null)
                    {
                        new VentanaAgregarCosmetico(cosmetico).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Cosmético no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre del cosmético seleccionado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila entera para poder editar un cosmetico.");
            }
        }

        private void btn_salir(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarNombreCosmetico(object sender, EventArgs e)
        {
            dtgDatos.DataSource = conexion.BuscarPorNombreCosmeticos(txt_Nombre_Producto.Text).Tables[0];
        }

        private void TbEditar(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                string nombre = dtgDatos.SelectedRows[0].Cells["Nombre"].Value?.ToString().Trim();
                if (!string.IsNullOrEmpty(nombre))
                {
                    Cosmetico cosmetico = conexion.BuscarPorNombreCosmetico(nombre);
                    if (cosmetico != null)
                    {
                        new VentanaAgregarCosmetico(cosmetico).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Cosmético no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la fila entera para poder editar un cosmetico.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila entera para poder editar un cosmetico.");
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                string nombre = dtgDatos.SelectedRows[0].Cells["Nombre"].Value?.ToString().Trim();
                if (!string.IsNullOrEmpty(nombre))
                {
                    Cosmetico cosmetico = conexion.BuscarPorNombreCosmetico(nombre);
                    if (cosmetico != null)
                    {
                        conexion.EliminarCosmetico(cosmetico.IDCosmetico);
                        dtgDatos.DataSource = conexion.BuscarPorNombreCosmeticos(txt_Nombre_Producto.Text).Tables[0];
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cosmético no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la fila entera para poder eliminar un cosmetico.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila entera para poder eliminar un cosmetico.");
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
