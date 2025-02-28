using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionCompra
    {
        private string StringConexion;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        public ConexionCompra(string pStringCnx)
        {
            StringConexion = pStringCnx;
        }




        public void GuardarCompra(Compra compra)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;

                _command.CommandText = "[Sp_Ins_Compra]";

                _command.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                _command.Parameters.AddWithValue("@TotalCompra", compra.TotalCompra);
                _command.Parameters.AddWithValue("@MetodoPago", compra.MetodoPago);
                _command.Parameters.AddWithValue("@Proveedor", compra.Proveedor);
                _command.Parameters.AddWithValue("@CantidadProductos", compra.CantidadProductos);
                _command.Parameters.AddWithValue("@EstadoCompra", compra.EstadoCompra);
                _command.Parameters.AddWithValue("@IDCosmeticos", compra.IDCosmeticos);
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

        public void ModificarCompra(Compra compra)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();

                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Upd_Compra]";

                _command.Parameters.AddWithValue("@IDCompra", compra.IDCompra);
                _command.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                _command.Parameters.AddWithValue("@TotalCompra", compra.TotalCompra);
                _command.Parameters.AddWithValue("@MetodoPago", compra.MetodoPago);
                _command.Parameters.AddWithValue("@Proveedor", compra.Proveedor);
                _command.Parameters.AddWithValue("@CantidadProductos", compra.CantidadProductos);
                _command.Parameters.AddWithValue("@EstadoCompra", compra.EstadoCompra);
                _command.Parameters.AddWithValue("@IDCosmeticos", compra.IDCosmeticos);
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




        public void EliminarCompra(int IDCompra)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Del_Compra]";
                _command.Parameters.AddWithValue("@IDCompra", IDCompra);
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

        public Compra MostrarIDCompra(int IDCompra)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_IDCompra]";
                _command.Parameters.AddWithValue("@IDCompra", IDCompra);
                _reader = _command.ExecuteReader();
                Compra temp = null;

                if (_reader.Read())
                {
                    temp = new Compra();
                    temp.IDCompra = int.Parse(_reader.GetValue(0).ToString());
                    temp.FechaCompra = DateTime.Parse(_reader.GetValue(1).ToString());
                    temp.TotalCompra = double.Parse(_reader.GetValue(2).ToString());
                    temp.MetodoPago = _reader.GetValue(3).ToString();
                    temp.Proveedor = _reader.GetValue(4).ToString();

                    temp.CantidadProductos = int.Parse(_reader.GetValue(5).ToString());
                    temp.EstadoCompra = _reader.GetValue(6).ToString();      
                    temp.IDCosmeticos = int.Parse(_reader.GetValue(7).ToString());
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


        public DataSet BuscarPorEstadoCompra(string estadoCompra)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_EstadoCompra]";
                _command.Parameters.AddWithValue("@EstadoCompra", estadoCompra);
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

