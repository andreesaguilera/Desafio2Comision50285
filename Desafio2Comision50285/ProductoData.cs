using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Collections;

namespace Desafio2Comision50285
{
    internal class ProductoData
    {
        private static string connectionString;

        static ProductoData()
        {
            connectionString = "Data Source=NEDARKIS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
        public static Producto ObtenerProducto(int IdProducto)
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT Id, Descripcion, Costo, PrecioVenta, Stock,IdUsuario FROM Producto WHERE Id=@IdProducto;";
                SqlCommand sqlcommand = new SqlCommand(query, connection);

                var parametro = new SqlParameter();
                parametro.ParameterName = "IdProducto";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Value = IdProducto;

                sqlcommand.Parameters.Add(parametro);


                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    var producto = new Producto();
                    producto.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Costo = Convert.ToDecimal(reader["Costo"]);
                    producto.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                    producto.Stock = Convert.ToInt32(reader["Stock"]);
                    producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    lista.Add(producto);



                }
            }

            return lista;


        }
        public static List<Producto> ListaProductos()
        {
            List<Producto> listarProducto = new List<Producto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario FROM Producto;";
                SqlCommand sqlcommand = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    var producto = new Producto();
                    producto.IdProducto = Convert.ToInt32(reader["id"]);
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Costo = Convert.ToDecimal(reader["Costo"]);
                    producto.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                    producto.Stock = Convert.ToInt32(reader["Stock"]);
                    producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    listarProducto.Add(producto); ;



                }
                return listarProducto;
            }

        }
        public static void CrearProducto(Producto producto)
        {
            var query = "INSERT INTO Producto (Descripcion,Costo,PrecioVenta,Stock,IdUsuario)" +
                        "VALUES (@Descripcion,@Costo,@PrecioVenta,@Stock,@IdUsuario)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {

                    sqlcommand.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    sqlcommand.Parameters.Add(new SqlParameter("Costo", SqlDbType.VarChar) { Value = producto.Costo });
                    sqlcommand.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.VarChar) { Value = producto.PrecioVenta });
                    sqlcommand.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = producto.Stock });
                    sqlcommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });

                    sqlcommand.ExecuteNonQuery();
                }



                connection.Close();


            }


        }
        public static void ModificarProducto(Producto producto)
        {
            var query = " UPDATE Producto " +
                        " SET " +
                        " Descripcion = @Descripcion, " +
                        " Costo = @Costo, " +
                        " PrecioVenta = @PrecioVenta, " +
                        " Stock = @Stock, " +
                        " IdUsuario = @IdUsuario " +
                        " WHERE ID = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {

                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.IdProducto });
                    sqlcommand.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    sqlcommand.Parameters.Add(new SqlParameter("Costo", SqlDbType.VarChar) { Value = producto.Costo });
                    sqlcommand.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.VarChar) { Value = producto.PrecioVenta });
                    sqlcommand.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = producto.Stock });
                    sqlcommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });
                    

                    sqlcommand.ExecuteNonQuery();
                }

                connection.Close();


            }
        }

        public static void EliminarProducto(Producto producto)
        {
                var query = "DELETE FROM Producto WHERE Id = @Id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                    {
                        sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.IdProducto });

                        sqlcommand.ExecuteNonQuery();

                    }

                    connection.Close();


                }


        }


    }
}
