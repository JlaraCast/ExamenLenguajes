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
using DAL;

namespace ExamenGrupo5
{
    public partial class VentanaConsumidor : Form
    {
        private Conexion _conexion = null;
        public VentanaConsumidor()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            ShowToolTipOnMouseUp(pictureBox1, "Actualizar");
            Buscar("");

        }

        private void ImprimirBTN_Click(object sender, EventArgs e)
        {

        }

        // Método para mostrar el informe de usuarios en un formulario
        public void MostrarInforme()
        {
            try
            {
                // Se crea una instancia del formulario FrmRepConsumidores
                //FrmRepConsumidores formulario = new FrmRepConsumidores();

                //// Se actualiza la lista de usuarios cuando se cierra el formulario
                //formulario.FormClosed += (s, args) => Buscar("");

                //// Se muestra el formulario de informe de usuarios en un diálogo modal
                //formulario.ShowDialog();

                //// Se libera la memoria del formulario después de cerrarlo
                //formulario.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgDatos.SelectedRows.Count > 0)
                {
                    int id = int.Parse(this.dtgDatos.SelectedRows[0].Cells["IdConsumidor"].Value.ToString());
                    MostrarVentanaConsumidor("Modificar", id);
                }
                else
                {
                    throw new Exception("Seleccione la fila de usuario que desea modificar");
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Evento para eliminar un usuario seleccionado en el DataGridView
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgDatos.SelectedRows.Count > 0)
                {
                    // Se procede a eliminar los datos del usuario
                    _conexion.EliminarConsumidor(int.Parse(this.dtgDatos.SelectedRows[0].Cells["IdConsumidor"].Value.ToString()));

                    // Se actualiza la lista de usuarios
                    this.Buscar("");
                }
                else
                {
                    throw new Exception("Seleccione la fila del usuario que desea eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_Nombre_Completo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar(this.txt_Nombre_Completo.Text.Trim());
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

        private void Buscar(string pNombre)
        {
            try
            {
                this.dtgDatos.DataSource = _conexion.BuscarPorEstadoConsumidor(pNombre).Tables[0];
                this.dtgDatos.AutoResizeColumns();
                this.dtgDatos.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarVentanaConsumidor("Crear", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

    private void MostrarVentanaConsumidor(string funcion, int id)
        {
            try
            {
                VentanaGestionConsumidor ventana = new VentanaGestionConsumidor(funcion, id);
                ventana.FormClosed += (s, args) => Buscar("");
                ventana.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtgDatos.SelectedRows.Count > 0)
                {
                    // Se procede a eliminar los datos del usuario
                    _conexion.EliminarConsumidor(int.Parse(this.dtgDatos.SelectedRows[0].Cells["IdConsumidor"].Value.ToString()));

                    // Se actualiza la lista de usuarios
                    this.Buscar("");
                }
                else
                {
                    throw new Exception("Seleccione la fila del usuario que desea eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
