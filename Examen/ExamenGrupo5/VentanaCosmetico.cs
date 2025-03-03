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
using ToolTip = System.Windows.Forms.ToolTip;

namespace ExamenGrupo5
{
    public partial class VentanaCosmetico : Form
    {
        Conexion conexion;
        public VentanaCosmetico()
        {
            InitializeComponent();
            conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            ShowToolTipOnMouseUp(pictureBox1, "Actualizar");
            Buscar("");
        }

        private void Agregar_click(object sender, EventArgs e)
        {
            VentanaAgregarCosmetico ventana = new VentanaAgregarCosmetico();
            ventana.FormClosed += (s, args) => Buscar(""); // Actualizar la tabla al cerrar la ventana
            ventana.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.SelectedRows.Count > 0)
                {
                    string nombre = dtgDatos.SelectedRows[0].Cells["Nombre"].Value?.ToString().Trim();
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        Cosmetico cosmetico = conexion.BuscarPorNombreCosmetico(nombre);
                        if (cosmetico != null)
                        {
                            VentanaAgregarCosmetico ventana = new VentanaAgregarCosmetico(cosmetico);
                            ventana.FormClosed += (s, args) => Buscar("");
                            ventana.Show();
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
                    throw new Exception("Seleccione la fila entera para poder editar un cosmético.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar(string pNombre)
        {
            try
            {
                dtgDatos.DataSource = conexion.BuscarPorNombreCosmeticos(txt_Nombre_Producto.Text).Tables[0];
                dtgDatos.AutoResizeColumns();
                dtgDatos.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_salir(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarNombreCosmetico(object sender, EventArgs e)
        {
            try
            {
                Buscar(txt_Nombre_Producto.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbEditar(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.SelectedRows.Count > 0)
                {
                    string nombre = dtgDatos.SelectedRows[0].Cells["Nombre"].Value?.ToString().Trim();
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        Cosmetico cosmetico = conexion.BuscarPorNombreCosmetico(nombre);
                        if (cosmetico != null)
                        {
                            VentanaAgregarCosmetico ventana = new VentanaAgregarCosmetico(cosmetico);
                            ventana.FormClosed += (s, args) => Buscar(""); // Actualizar la tabla al cerrar la ventana
                            ventana.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Cosmético no encontrado.");
                        }
                    }
                    else
                    {
                        throw new Exception("Seleccione la fila entera para poder editar un cosmético.");
                    }
                }
                else
                {
                    throw new Exception("Seleccione la fila entera para poder editar un cosmético.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.SelectedRows.Count > 0)
                {
                    string nombre = dtgDatos.SelectedRows[0].Cells["Nombre"].Value?.ToString().Trim();
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        Cosmetico cosmetico = conexion.BuscarPorNombreCosmetico(nombre);
                        if (cosmetico != null)
                        {
                            if (conexion.CosmeticoVendido(cosmetico.IDCosmetico))
                            {
                                MessageBox.Show("El cosmético ha sido vendido. Se marcará como 'Inactivo' en lugar de eliminarlo.",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                cosmetico.EstadoProducto = "Inactiva";
                                conexion.ModificarCosmetico(cosmetico);
                            }
                            else
                            {
                                conexion.EliminarCosmetico(cosmetico.IDCosmetico);
                            }

                            Buscar("");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Cosmético no encontrado.");
                        }
                    }
                    else
                    {
                        throw new Exception("Seleccione la fila entera para poder eliminar un cosmético.");
                    }
                }
                else
                {
                    throw new Exception("Seleccione la fila entera para poder eliminar un cosmético.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowToolTipOnMouseUp(PictureBox pictureBox, string message)
        {
            ToolTip toolTip = new ToolTip();

            pictureBox.MouseUp += (sender, e) =>
            {
                toolTip.SetToolTip(pictureBox, message);
            };
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarInforme();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarInforme()
        {
            try
            {
                // Implementar la lógica para mostrar el informe de cosméticos
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
