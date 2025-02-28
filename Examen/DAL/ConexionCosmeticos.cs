using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class ConexionCosmeticos
    {
        private string StringConexion;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        public ConexionCosmeticos(string pStringCnx)
        {
            StringConexion = pStringCnx;
        }




        public void GuardarCosmetico(Cosmetico cosmetico)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;

                _command.CommandText = "[Sp_Ins_Cosmeticos]";

                    _command.Parameters.AddWithValue("@Nombre", cosmetico.Nombre);
                _command.Parameters.AddWithValue("@Marca", cosmetico.Marca);
                _command.Parameters.AddWithValue("@PrecioUnitario", cosmetico.PrecioUnitario);
                _command.Parameters.AddWithValue("@StockDisponible", cosmetico.StockDisponible);
                _command.Parameters.AddWithValue("@FechaVencimiento", cosmetico.FechaVencimiento);
                _command.Parameters.AddWithValue("@EstadoProducto", cosmetico.EstadoProducto);
                _command.Parameters.AddWithValue("@Categoria", cosmetico.Categoria);
                _command.Parameters.AddWithValue("@Imagen", cosmetico.Imagen);

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

        public void ModificarCosmetico(Cosmetico cosmetico)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();

                _command.Connection = _connection;
                _command.CommandType = CommandType.StoredProcedure;

                _command.CommandText = "[Sp_Upd_Cosmeticos]";

                _command.Parameters.AddWithValue("@IDCosmeticos", cosmetico.IDCosmetico);
                _command.Parameters.AddWithValue("@Nombre", cosmetico.Nombre);
                _command.Parameters.AddWithValue("@Marca", cosmetico.Marca);
                _command.Parameters.AddWithValue("@PrecioUnitario", cosmetico.PrecioUnitario);
                _command.Parameters.AddWithValue("@StockDisponible", cosmetico.StockDisponible);

                _command.Parameters.AddWithValue("@EstadoProducto", cosmetico.EstadoProducto);
                _command.Parameters.AddWithValue("@FechaVencimiento", cosmetico.FechaVencimiento);
                _command.Parameters.AddWithValue("@Categoria", cosmetico.Categoria);
                _command.Parameters.AddWithValue("@Imagen", cosmetico.Imagen);
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




        public void EliminarCosmetico(int IDCosmetico)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Del_Cosmetico]";
                _command.Parameters.AddWithValue("@IDCosmeticos", IDCosmetico);
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

        public Cosmetico MostrarCosmetico(int IDCosmetico)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;

                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_IDCosmetico]";
                _command.Parameters.AddWithValue("@IDCosmeticos", IDCosmetico);
                _reader = _command.ExecuteReader();
                Cosmetico temp = null;

                if (_reader.Read())
                {
                    temp = new Cosmetico();
                    temp.IDCosmetico = int.Parse(_reader.GetValue(0).ToString());
                    temp.Nombre = _reader.GetValue(1).ToString();
                    temp.Marca = _reader.GetValue(2).ToString();
                    temp.PrecioUnitario = double.Parse(_reader.GetValue(3).ToString());
                    temp.StockDisponible = int.Parse(_reader.GetValue(4).ToString());
                    temp.FechaVencimiento = DateTime.Parse(_reader.GetValue(5).ToString());
                    temp.Categoria = _reader.GetValue(6).ToString();
                    temp.EstadoProducto = _reader.GetValue(7).ToString();
                    temp.Imagen = _reader.GetValue(8).ToString();

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


        public DataSet BuscarPorNombreCosmeticos(string nombre)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;
                
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[Sp_Most_Cosmetico]";
                _command.Parameters.AddWithValue("@Nombre", nombre);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet datos = new DataSet();
                adapter.SelectCommand = _command;
                adapter.Fill(datos);
                _connection.Close();
                _connection.Dispose();
                _command.Dispose();
                adapter.Dispose();
                return datos;
            



            } catch (Exception e)
            {
                throw e;
            }
        }

        //    public DataSet BuscarPorNombreUsuario(String nombre)
        //    {
        //        try
        //        {
        //            _connection = new SqlConnection(StringConexion);
        //            _connection.Open();
        //            _command = new SqlCommand();
        //            _command.Connection = _connection;

        //            _command.CommandType = CommandType.StoredProcedure;
        //            _command.CommandText = "[Sp_Buscar_Nombres_Usuarios]";
        //            _command.Parameters.AddWithValue("@Nombre", nombre);
        //            SqlDataAdapter adapter = new SqlDataAdapter();
        //            DataSet datos = new DataSet();
        //            adapter.SelectCommand = _command;
        //            adapter.Fill(datos);
        //            _connection.close();
        //            _connection.Dispose();
        //            _command.Dispose();
        //            adapter.dispose();
        //            return datos;
        //        }
        //        catch (Exception ex)
        //        {
        //            Throw ex;
        //        }
        //    }



        //    public void BuscarPorEmaiUsuarios(String Email)
        //    {
        //        try
        //        {
        //            _connection = new SqlConnection(StringConexion);
        //            _connection.Open();
        //            _command = new SqlCommand();
        //            _command.Connection = _connection;

        //            _command.CommandType = CommandType.StoredProcedure;
        //            _command.CommandText = "[Sp_Buscar_Email_Usuario]";
        //            _command.Parameters.AddWithValue("@Email", Email);
        //            _reader = _command.ExecuteReader();
        //            Usuario temp = null;

        //            if (_reader.Read())
        //            {
        //                temp = new Usuario();
        //                temp.Email = _reader.GetValue(0).ToString();
        //                temp.NombreCompleto = _reader.GetValue(1).ToString();
        //                temp.Password = _reader.GetValue(2).ToString();
        //                temp.FechaRegistro = DateTime.Parse(_reader.GetValue(3).ToString());
        //            }
        //            _connection.Close();
        //            _connection.Dispose();
        //            _command.Dispose();
        //            return temp;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex
        //        }
        //    }






        //    public void ValidarUsuario(string pEmail, string pPassword)
        //    {
        //        try
        //        {
        //            _connection = new SqlConnection(StringConexion);
        //            _connection.Open();
        //            _command = new SqlCommand();
        //            _command.Connection = _connection;

        //            _command.CommandType = CommandType.StoredProcedure;
        //            _command.CommandText = "[Sp_Cns_Usuario]";
        //            _command.Parameters.AddWithValue("pEmail", pEmail);
        //            _command.Parameters.AddWithValue("@pPw", pPassword);
        //            _reader = _command.ExecuteReader();
        //            Usuario temp = null;

        //            if (_reader.Read())
        //            {
        //                temp = new Usuario();
        //                temp.Email = _reader.GetValue(0).ToString();
        //                temp.NombreCompleto = _reader.GetValue(1).ToString();
        //                temp.Password = _reader.GetValue(2).ToString();
        //                temp.FechaRegistro = DateTime.Parse(_reader.GetValue(3).ToString());
        //            }
        //            _connection.Close();
        //            _connection.Dispose();
        //            _command.Dispose();
        //            return temp;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex
        //        }
        //    }





        //    public void ModificarClaveUsuario(string pEmail, string pPassword)
        //    {
        //        try
        //        {
        //            _connection = newSqlConnection(StringConexion);
        //            _connection.Open();
        //            _command = SqlCommand();
        //            _command.Connection = _connection;
        //            _command.CommandType = CommandType.StoredProcedure;
        //            _command.CommandText = "[Sp_Upd_Pass_Usuarios]";
        //            _command.Parameters.AddWithValue("@Email", pEmail);
        //            _command.Parameters.AddWithValue("@pPwNew", pPassword);

        //            _command.ExecuteNonQuery();
        //            _connection.Dispose();
        //            _command.Dispose();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }

        //}
    }
}
