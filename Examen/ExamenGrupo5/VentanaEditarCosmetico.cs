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
    public partial class VentanaEditarCosmetico : Form
    {
        Conexion _conexion = null;
        Cosmetico cosmetico = null;
        public VentanaEditarCosmetico(Cosmetico cosmetico)
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);

            this.cosmetico = cosmetico;
            
        }
        private void CargarDatos()
        {
            this.txtNombre.Text = cosmetico.Nombre;
            this.txtMarca.Text = cosmetico.Marca;
            this.spPrecio.Value = (decimal)cosmetico.PrecioUnitario;
            this.spPrecio.Value = cosmetico.StockDisponible;
            this.dtpFecha.Value = cosmetico.FechaVencimiento;
            this.cbCategoria.SelectedItem = cosmetico.Categoria;
            this.cbEstado.SelectedItem = cosmetico.EstadoProducto;
            this.pbImagen.ImageLocation = cosmetico.Imagen;
        }

        private void btnAceptar(object sender, EventArgs e)
        {

        }

        private void btnCancelar(object sender, EventArgs e)
        {

        }

        private void pbEditImg(object sender, EventArgs e)
        {
        }

        private void pbSalir(object sender, EventArgs e)
        {

            this.Dispose();
        }
    }
}
