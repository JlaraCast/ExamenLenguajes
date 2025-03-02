using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ExamenGrupo5
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {

            new VentanaVentas().ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCosmeticosCLick(object sender, EventArgs e)
        {
            new VentanaCosmetico().ShowDialog();
        }

        private void SalirClick(object sender, EventArgs e)
        {
            Close();
        }

        private void compras(object sender, EventArgs e)
        {
            new VentanaVentas().ShowDialog();
        }
    }
}
