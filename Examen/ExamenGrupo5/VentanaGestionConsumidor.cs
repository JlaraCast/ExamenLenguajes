﻿using System;
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
        private readonly Conexion _conexion = null;
        private Consumidor _consumidor;
        private readonly string _tipoSolicitud;
        private readonly int _id;

        public VentanaGestionConsumidor(string tipoSolicitud, int id)
        {
            InitializeComponent();
            _id = id;
            _tipoSolicitud = tipoSolicitud;
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);
            _consumidor = new Consumidor();
            numericUpDownFrecuencia.Minimum = 1; // Asegura que el valor mínimo sea 1
            numericUpDownFrecuencia.Value = 1;
            Comprobar_Tipo_Solicitud();
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
                    verificar_Campos();
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

        public void Modificar_Consumidor()
        {
            _consumidor = new Consumidor()
            {
                IdConsumidor = _id,
                NombreCompleto = txt_Nombre.Text.Trim(),
                telefono = txt_Telefono.Text.Trim(),
                CorreoElectronico = txt_Correo.Text.Trim(),
                FechaRegistro = dateTimePickerFechaVencimiento.Value,
                FrecuenciaCompra = numericUpDownFrecuencia.Value.ToString(),
                PuntosFidelidad = (int)numericUpDownFidelidad.Value,
                Direccion = txt_Direccion.Text.Trim()
            };
            // Guardar el consumidor en la base de datos
            if (_consumidor == null)
            {
                throw new ArgumentNullException(nameof(_consumidor), "El objeto consumidor no puede ser null.");
            }
            else
            {
                _conexion.ModificarConsumidor(_consumidor);
                MessageBox.Show("El objeto consumidor se Modifico.");
                this.Close();
                new VentanaConsumidor();

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

            txt_Id.Text = _consumidor.IdConsumidor.ToString();
            txt_Nombre.Text = _consumidor.NombreCompleto;
            txt_Telefono.Text = _consumidor.telefono;
            txt_Correo.Text = _consumidor.CorreoElectronico;
            dateTimePickerFechaVencimiento.Value = _consumidor.FechaRegistro;
            if (!string.IsNullOrEmpty(_consumidor.FrecuenciaCompra) && int.TryParse(_consumidor.FrecuenciaCompra, out int frecuencia))
            {
                numericUpDownFrecuencia.Value = Math.Max(frecuencia, 1); // Si es menor que 1, se asigna 1
            }
            else
            {
                numericUpDownFrecuencia.Value = 1; // Valor por defecto si no hay datos
            }
            numericUpDownFidelidad.Value = _consumidor.PuntosFidelidad;
            txt_Direccion.Text = _consumidor.Direccion;
        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar los campos antes de continuar
                if (verificar_Campos())
                {
                    // Si no hay errores, continuar con la operación
                    if (_tipoSolicitud.Equals("Crear"))
                    {
                        Guardar_Consumidor();
                        MessageBox.Show("Consumidor registrado correctamente", "Ingreso realizado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                    // Verificar si la operación es "Modificar" o "Perfil"
                    if (_tipoSolicitud.Equals("Modificar"))
                    {
                        // Modificar el consumidor
                        Modificar_Consumidor();

                        // Si se realizó correctamente, mostrar mensaje de éxito
                        MessageBox.Show("Consumidor modificado correctamente", "Modificación realizada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si algo sale mal
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new VentanaConsumidor();
        }

        public bool verificar_Campos()
        {
            // Lista para acumular mensajes de error
            List<string> mensajesError = new List<string>();

            // Verificar que los campos de texto no estén vacíos o contengan solo espacios en blanco
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                mensajesError.Add("El campo de nombre no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(txt_Telefono.Text))
            {
                mensajesError.Add("El campo de teléfono no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(txt_Correo.Text))
            {
                mensajesError.Add("El campo de correo electrónico no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
            {
                mensajesError.Add("El campo de dirección no puede estar vacío.");
            }

            // Verificar que la fecha no sea futura
            if (dateTimePickerFechaVencimiento.Value > DateTime.Now)
            {
                mensajesError.Add("La fecha de registro no puede ser en el futuro.");
            }

            // Verificar que la frecuencia de compra sea mayor a 0
            if (numericUpDownFrecuencia.Value <= 0)
            {
                mensajesError.Add("La frecuencia de compra debe ser mayor a 0.");
            }

            // Verificar que los puntos de fidelidad no sean negativos
            if (numericUpDownFidelidad.Value < 0)
            {
                mensajesError.Add("Los puntos de fidelidad no pueden ser negativos.");
            }

            // Si hay mensajes de error, mostrarlos todos juntos
            if (mensajesError.Count > 0)
            {
                throw new Exception("Errores de validación:\n" + string.Join("\n", mensajesError));
                //return false;
            }

            // Si no hay errores, retornar true
            return true;
        }

        private void Guardar_Consumidor()
        {
            try
            {

                // Buscar el consumidor por email
                Consumidor consumidor = _conexion.MostrarNombreConsumidor(txt_Nombre.Text);

                // Verificar si el consumidor con ese email ya existe
                if (consumidor != null)
                {
                    throw new Exception("El nombre ya ha sido registrado, intente con otro.");
                }

                // Instanciar un nuevo consumidor
                _consumidor = new Consumidor()
                {
                    NombreCompleto = txt_Nombre.Text.Trim(),
                    telefono = txt_Telefono.Text.Trim(),
                    CorreoElectronico = txt_Correo.Text.Trim(),
                    FechaRegistro = dateTimePickerFechaVencimiento.Value,
                    FrecuenciaCompra = numericUpDownFrecuencia.Value.ToString(),
                    PuntosFidelidad = (int)numericUpDownFidelidad.Value,
                    Direccion = txt_Direccion.Text.Trim()
                };

                // Guardar el consumidor en la base de datos
                if (_consumidor == null)
                {
                    throw new ArgumentNullException(nameof(_consumidor), "El objeto consumidor no puede ser null.");
                }
                else
                {
                    _conexion.GuardarConsumidor(_consumidor);
                    MessageBox.Show("El objeto consumidor se guardo.");
                    this.Close();
                    new VentanaConsumidor();

                }

            }
            catch (Exception ex)
            {
                // Relanzar la excepción para que pueda ser manejada en un nivel superior
                throw new Exception("Error al guardar el consumidor: " + ex.Message, ex);
            }
        }
        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            // Si este evento no es necesario, puedes dejarlo vacío o eliminarlo del `Designer.cs`
        }


    }
}