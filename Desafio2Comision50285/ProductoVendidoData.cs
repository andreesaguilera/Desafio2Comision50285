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
    internal class ProductoVendidoData
    {
        private static string connectionString;

        static ProductoVendidoData()
        {
            connectionString = "Data Source=NEDARKIS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
        public static List<ProductoVendido> ObtenerProductoVendido(int IdProductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido WHERE Id=@IdProductoVendido;";
                
                SqlCommand sqlcommand = new SqlCommand(query, connection);

                var parametro = new SqlParameter();
                parametro.ParameterName = "IdProductoVendido";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Value = IdProductoVendido;

                sqlcommand.Parameters.Add(parametro);


                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    var productoVendido = new ProductoVendido();
                    productoVendido.Id = Convert.ToInt32(reader["Id"]);
                    productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                    productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                    productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                  
                    
                    lista.Add(productoVendido);



                }
            }

            return lista;


        }
        public static List<ProductoVendido> ListaProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido";
                SqlCommand sqlcommand = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    var productoVendidos = new ProductoVendido();
                    productoVendidos.Id = Convert.ToInt32(reader["Id"]);
                    productoVendidos.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                    productoVendidos.Stock = Convert.ToInt32(reader["Stock"]);
                    productoVendidos.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                   
                    lista.Add(productoVendidos); ;



                }
                return lista;
            }

        }
        public static void CrearProductoVendido(ProductoVendido productoCreado)
        {
            var query = "INSERT INTO ProductoVendido (Id, IdProducto, Stock, IdVenta)" +
                        "VALUES (@Id,@IdProducto,@Stock,@IdVenta)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {

                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoCreado.Id });
                    sqlcommand.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoCreado.IdProducto });
                    sqlcommand.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoCreado.Stock });
                    sqlcommand.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoCreado.IdVenta });
                    

                    sqlcommand.ExecuteNonQuery();
                }



                connection.Close();


            }


        }
        public static void ModificarProductoVendido(ProductoVendido productoModificado)
        {
            var query = "UPDATE ProductoVendido " +
                        "SET " +
                        "Id = @Id, " +
                        "IdProducto = @IdProducto, " +
                        "Stock = @Stock, " +
                        "IdVenta = @IdVenta, " +                        
                        "WHERE ID = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {

                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = productoModificado.Id });
                    sqlcommand.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = productoModificado.IdProducto });
                    sqlcommand.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = productoModificado.Stock });
                    sqlcommand.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.VarChar) { Value = productoModificado.IdVenta });
                    


                    sqlcommand.ExecuteNonQuery();
                }

                connection.Close();


            }
        }
        public static void EliminarProductoVendido(ProductoVendido productoEliminado)
        {
            var query = "DELETE FROM ProductoVendido WHERE IdProducto = @IdProducto";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {
                    sqlcommand.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoEliminado.IdProducto });

                    sqlcommand.ExecuteNonQuery();

                }

                connection.Close();


            }


        }
    }
}
