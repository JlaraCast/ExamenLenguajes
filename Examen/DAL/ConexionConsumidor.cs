using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionConsumidor
    {

        private string StringConexion;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        public ConexionConsumidor(string pStringCnx)
        {
            StringConexion = pStringCnx;
        }

        public void GuardarConsumidor(Consumidor consumidor)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;
                _command.CommandType = CommandType.StoredProcedure;

                _command.CommandText = "[Sp_Ins_Consumidor]";

                _command.Parameters.AddWithValue("@NombreCompleto", consumidor.NombreCompleto);
                _command.Parameters.AddWithValue("@telefono", consumidor.telefono);
                _command.Parameters.AddWithValue("@CorreoElectronico", consumidor.CorreoElectronico);
                _command.Parameters.AddWithValue("@FechaRegistro", consumidor.FechaRegistro);
                _command.Parameters.AddWithValue("@FrecuenciaCompra", consumidor.FrecuenciaCompra);
                _command.Parameters.AddWithValue("@PuntosFidelidad", consumidor.PuntosFidelidad);
                _command.Parameters.AddWithValue("@Direccion", consumidor.Direccion);

                _command.ExecuteNonQuery();
                _connection.Close();
                _connection.Dispose();
                _command.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ModificarConsumidor(Consumidor consumidor)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();

                _command = new SqlCommand();

                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;

                _command.CommandText = "[Sp_Upd_Consumidor]";

                _command.Parameters.AddWithValue("@IDConsumidor", consumidor.IdConsumidor);
                _command.Parameters.AddWithValue("@NombreCompleto", consumidor.NombreCompleto);
                _command.Parameters.AddWithValue("@telefono", consumidor.telefono);
                _command.Parameters.AddWithValue("@CorreoElectronico", consumidor.CorreoElectronico);
                _command.Parameters.AddWithValue("@FechaRegistro", consumidor.FechaRegistro);
                _command.Parameters.AddWithValue("@FrecuenciaCompra", consumidor.FrecuenciaCompra);
                _command.Parameters.AddWithValue("@PuntosFidelidad", consumidor.PuntosFidelidad);
                _command.Parameters.AddWithValue("@Direccion", consumidor.Direccion);
                _command.ExecuteNonQuery();
                _connection.Close();
                _connection.Dispose();
                _command.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarConsumidor(int idConsumidor)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();

                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;

                _command.CommandText = "[Sp_Del_Consumidor]";

                _command.Parameters.AddWithValue("@IDConsumidor", idConsumidor);
                
                _command.ExecuteNonQuery();
                _connection.Close();
                _connection.Dispose();
                _command.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Consumidor MostrarIDConsumidor(int IDConsumidor)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_IDConsumidor]";
                _command.Parameters.AddWithValue("@IDConsumidor", IDConsumidor);
                _reader = _command.ExecuteReader();
                Consumidor temp = null;

                if (_reader.Read())
                {
                    temp = new Consumidor();
                    temp.IdConsumidor = int.Parse(_reader.GetValue(0).ToString());
                    temp.NombreCompleto = _reader.GetValue(1).ToString();
                    temp.telefono = _reader.GetValue(2).ToString();
                    temp.CorreoElectronico = _reader.GetValue(3).ToString();
                    temp.FechaRegistro = DateTime.Parse(_reader.GetValue(4).ToString());
                    temp.FrecuenciaCompra= _reader.GetValue(5).ToString();
                    temp.PuntosFidelidad= int.Parse(_reader.GetValue(6).ToString());
                    temp.Direccion = _reader.GetValue(7).ToString();

                }
                _connection.Close();
                _connection.Dispose();
                _command.Dispose();
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet BuscarPorEstadoConsumidor(String NombreCompleto)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_ConsumidorNombre]";
                _command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet datos = new DataSet();
                adapter.SelectCommand = _command;
                adapter.Fill(datos);
                _connection.Close();
                _connection.Dispose();
                _command.Dispose();
                adapter.Dispose();
                return datos;

            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }
}
