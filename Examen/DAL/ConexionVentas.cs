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
    public class ConexionVentas
    {
        private string StringConexion;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        public ConexionVentas(string pStringCnx)
        {
            StringConexion = pStringCnx;
        }

        public void GuardarVentas(Venta venta)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;

                _command.CommandText = "[Sp_Ins_Venta]";

                _command.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
                _command.Parameters.AddWithValue("@TotalVenta", venta.TotalVenta);
                _command.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
                _command.Parameters.AddWithValue("@PuntosUsados", venta.PuntosUsados);
                _command.Parameters.AddWithValue("@CantidadVendido", venta.CantidadVendido);
                _command.Parameters.AddWithValue("@IDCosmeticos", venta.IDCosmetico);
                _command.Parameters.AddWithValue("@IDConsumidor", venta.IDConsumidor);
                _command.Parameters.AddWithValue("@EstadoVenta", venta.EstadoVenta);
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


        public void ModificarVenta(Venta venta)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();

                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Upd_Venta]";

                _command.Parameters.AddWithValue("@IDVenta", venta.IdVenta);
                _command.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
                _command.Parameters.AddWithValue("@TotalVenta", venta.TotalVenta);
                _command.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
                _command.Parameters.AddWithValue("@PuntosUsados", venta.PuntosUsados);
                _command.Parameters.AddWithValue("@CantidadVendido", venta.CantidadVendido);
                _command.Parameters.AddWithValue("@IDCosmeticos", venta.IDCosmetico);
                _command.Parameters.AddWithValue("@IDConsumidor", venta.IDConsumidor);
                _command.Parameters.AddWithValue("@EstadoVenta", venta.EstadoVenta);
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




        public void EliminarVenta(int IdVenta)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Del_Venta]";
                _command.Parameters.AddWithValue("@IdVenta", IdVenta);
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

        public Venta MostrarIDVenta(int IdVenta)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_IDVenta]";
                _command.Parameters.AddWithValue("@IdVenta", IdVenta);
                _reader = _command.ExecuteReader();
                Venta temp = null;

                if (_reader.Read())
                {
                    temp = new Venta();
                    temp.IdVenta = int.Parse(_reader.GetValue(0).ToString());
                    temp.FechaVenta = DateTime.Parse(_reader.GetValue(1).ToString());
                    temp.TotalVenta = double.Parse(_reader.GetValue(2).ToString());
                    temp.MetodoPago = _reader.GetValue(3).ToString();
                    temp.PuntosUsados = int.Parse(_reader.GetValue(4).ToString());
                    temp.CantidadVendido = int.Parse(_reader.GetValue(5).ToString());
                    temp.IDCosmetico = int.Parse(_reader.GetValue(6).ToString());
                    temp.IDConsumidor = int.Parse(_reader.GetValue(7).ToString());
                    temp.EstadoVenta = _reader.GetValue(8).ToString();
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

        public DataSet BuscarPorEstadoVenta(string estadoVenta)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_EstadoVenta]";
                _command.Parameters.AddWithValue("@EstadoVenta",estadoVenta);
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


