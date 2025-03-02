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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenGrupo5
{

    public partial class VentanaCompras : Form
    {
        Conexion conexion;

        public VentanaCompras()
        {
            InitializeComponent();
            conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            dtgDatos.DataSource = conexion.BuscarPorEstadoVenta(comboBox1.SelectedItem.ToString()).Tables[0];
        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }

        private void EstadoCompraChanged(object sender, EventArgs e)
        {
            dtgDatos.DataSource = conexion.BuscarPorEstadoVenta(comboBox1.SelectedItem.ToString()).Tables[0];
        }

        private void Agregar_click(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {

        }


        private void TbEditar(object sender, EventArgs e)
        {

        }

        private void Eliminar(object sender, EventArgs e)
        {

        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // Implementar funcionalidad de impresión aquí
        }
    }
}
