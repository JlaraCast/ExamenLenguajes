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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExamenGrupo5
{
    public partial class VentanaGestionConsumidor : Form
    {
        private readonly conexion _conexion = null;
        private Consumidor _consumidor;
        private readonly string _tipoSolicitud;
        private readonly int _id;
        public VentanaGestionConsumidor(string tipoSolicitud, int id)
        {
            InitializeComponent();
            _id = id;
            _tipoSolicitud = tipoSolicitud;
            _conexion = new conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            _consumidor = new Consumidor();

            //comprobar_tipo_solicitud();
        }

        public void Comprobar_Tipo_Solicitud()
        {
            // Mostrar el campo de clave y sus controles asociados
            //Mostrar_Controles_Clave(true);

            switch (_tipoSolicitud)
            {
                // Verificar si el tipo de solicitud es "Solicitar"
                case "Crear":
                    txt_Id.Enabled = false;
                    //Crear_Datos_Consumidor();
                    // Ocultar el label y ComboBox de estado
                    break;

                // Verificar si el tipo de solicitud es "Modificar"
                case "Modificar":
                    // Llenar los datos del usuario para modificación
                    Llenar_Datos_Consumidor();

                    // Deshabilitar el campo de email
                    txt_Id.Enabled = false;
                    break;
            }
        }

        public void Llenar_Datos_Consumidor()
        {
            if (_id == 0)
            {
                MessageBox.Show("El id no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _consumidor = _conexion.MostrarIDConsumidor(_id);

            if (_consumidor == null)
            {
                MessageBox.Show("Consumidor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //txt_Email.Text = _usuario.Email;
            //txt_Nombre.Text = _usuario.NombreCompleto;
            //cb_Rol.SelectedItem = _usuario.Rol;
            //cb_Estado.SelectedItem = _usuario.Estado;
            //pb_Foto_Usuario_96.Image = Cargar_Imagen(_usuario.Foto);
        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
