﻿using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ExamenGrupo5
{
    public partial class VentanaCompras : Form
    {
        private Conexion conexion;

        public VentanaCompras()
        {
            InitializeComponent();
            conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            dtgDatos.DataSource = conexion.BuscarPorEstadoCompra(txt_Estado_compra.Text).Tables[0];
            ShowToolTipOnMouseUp(pictureBox1, "Actualizar");
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            new VentanaGestionCompras().ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                int idCompra = Convert.ToInt32(dtgDatos.SelectedRows[0].Cells["IDCompra"].Value);
                Compra compra = conexion.MostrarIDCompra(idCompra);

                if (compra != null)
                {
                    new VentanaGestionCompras(compra).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Compra no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar la compra.");
            }
        }

        private void BuscarCompraPorEstado(object sender, EventArgs e)
        {
            dtgDatos.DataSource = conexion.BuscarPorEstadoCompra(txt_Estado_compra.Text).Tables[0];
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                int idCompra = Convert.ToInt32(dtgDatos.SelectedRows[0].Cells["IDCompra"].Value);
                Compra compra = conexion.MostrarIDCompra(idCompra);

                if (compra != null)
                {
                    // Confirmación antes de eliminar
                    DialogResult confirmacion = MessageBox.Show(
                        "¿Está seguro de que desea eliminar esta compra?",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        conexion.EliminarCompra(compra.IDCompra);
                        dtgDatos.DataSource = conexion.BuscarPorEstadoCompra(txt_Estado_compra.Text).Tables[0];
                        MessageBox.Show("Compra eliminada correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Compra no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar la compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // Lógica para imprimir compras (por implementar)
        }

        private void ShowToolTipOnMouseUp(PictureBox pictureBox, string message)
        {
            ToolTip toolTip = new ToolTip();

            pictureBox.MouseUp += (sender, e) =>
            {
                toolTip.SetToolTip(pictureBox, message);
            };
        }

    }
}
