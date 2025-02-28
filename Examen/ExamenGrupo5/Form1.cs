using BLL; // Asegúrate de que el proyecto tenga una referencia al ensamblado que contiene el espacio de nombres 'BLL'.
using DAL;
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

namespace ExamenGrupo5
{
    public partial class Form1: Form
    {
        private ConexionCosmeticos  conexionCosmeticos = null;
        private ConexionCompra conexionCompra = null;
        private ConexionConsumidor conexionConsumidor= null;
        private ConexionVentas conexionVentas = null;
        public Form1()
        {
            conexionCosmeticos = new ConexionCosmeticos(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            conexionCompra = new ConexionCompra(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            conexionConsumidor = new ConexionConsumidor(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            conexionVentas = new ConexionVentas(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);

            InitializeComponent();
            dataGridView1.DataSource = conexionCosmeticos.BuscarPorNombreCosmeticos(textBox1.Text).Tables[0];
            //
            //dataGridView1.DataSource = conexionCompra.BuscarPorEstadoCompra(textBox1.Text).Tables[0];
            //dataGridView1.DataSource = conexionConsumidor.BuscarPorEstadoConsumidor(textBox1.Text).Tables[0];
            //dataGridView1.DataSource = conexionVentas.BuscarPorEstadoVenta(textBox1.Text).Tables[0];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = conexionCompra.BuscarPorEstadoCompra(textBox1.Text).Tables[0] ;
            dataGridView1.DataSource = conexionConsumidor.BuscarPorEstadoConsumidor(textBox1.Text).Tables[0] ;
        }                  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Compra cos = new Compra(1, DateTime.Parse("12/12/12"), 1, "so", 1, "so", 3, "so");
            //Consumidor consumidor = new Consumidor(1,"2", "2", "2", DateTime.Parse("12/12/12"), "2", 1, "2");
            //Venta venta = new Venta(2, DateTime.Parse("12/12/12"),1,"2",1,1,3,1,"2");
            Cosmetico cos = new Cosmetico(3, "so", "so", 1, 1, DateTime.Parse("12/12/12"), "so", "so", "so");


            //cos.Nombre = txtNombreProducto.Text;
            //cos.Marca = txtMarca.Text;
            //cos.PrecioUnitario = double.Parse(txtPrecioUnitario.Text);
            //cos.StockDisponible = int.Parse(txtStockDisponible.Text);
            //cos.FechaVencimiento = DateTime.Parse(txtFechaVencimiento.Text);
            //cos.Categoria = txtCategoria.Text;
            //cos.EstadoProducto = txtEstado.Text;
            //cos.Imagen = txtImgProducto.Text;

            //conexionCompra.GuardarCompra(cos);
            //conexionConsumidor.GuardarConsumidor(consumidor);
            //conexionVentas.GuardarVentas(venta);
            //conexionVentas.ModificarVenta(venta);
            //conexionVentas.EliminarVenta(2);
            //conexionConsumidor.ModificarConsumidor(consumidor);
            //conexionConsumidor.EliminarConsumidor(1);

            //  conexionCompra.ModificarCompra(cos);
            //conexionCompra.EliminarCompra(1);
            conexionCosmeticos.EliminarCosmetico(3);
        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int dato = int.Parse(textBox1.Text);
            conexionCosmeticos.EliminarCosmetico(dato);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Cosmetico cos = new Cosmetico();
            cos.Nombre = txtNombreProducto.Text;
            cos.IDCosmetico = int.Parse(textBox1.Text);
            cos.Marca = txtMarca.Text;
            cos.PrecioUnitario = double.Parse(txtPrecioUnitario.Text);
            cos.StockDisponible = int.Parse(txtStockDisponible.Text);
            cos.FechaVencimiento = DateTime.Parse(txtFechaVencimiento.Text);
            cos.Categoria = txtCategoria.Text;
            cos.EstadoProducto = txtEstado.Text;
            cos.Imagen = txtImgProducto.Text;

            conexionCosmeticos.ModificarCosmetico(cos);

        }
    }
}
