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
    internal class VentaData
    {
        private static string connectionString;

        static VentaData()
        {
            connectionString = "Data Source=NEDARKIS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
        public static List<Venta> ObtenerVenta(int Id)
        {
            List<Venta> lista = new List<Venta>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id=@Id;";
                SqlCommand sqlcommand = new SqlCommand(query, connection);

                var parametro = new SqlParameter();
                parametro.ParameterName = "Id";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Value = Id;

                sqlcommand.Parameters.Add(parametro);


                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    var ventaObtenida = new Venta();
                    ventaObtenida.Id = Convert.ToInt32(reader["Id"]);
                    ventaObtenida.Comentarios = reader["Comentarios"].ToString();
                    ventaObtenida.IdUsuario = Convert.ToInt32(reader["Stock"]);
                    
                    lista.Add(ventaObtenida);



                }
            }

            return lista;


        }
        public static List<Venta> ListarVenta()
        {
            List<Venta> lista = new List<Venta>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Comentarios, IdUsuario FROM Venta";
                SqlCommand sqlcommand = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    var listadoVentas = new Venta();
                    listadoVentas.Id = Convert.ToInt32(reader["Id"]);
                    listadoVentas.Comentarios = reader["Comentarios"].ToString();
                    listadoVentas.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    

                    lista.Add(listadoVentas); ;



                }
                return lista;
            }

        }
        public static void CrearVenta(Venta ventaCreada)
        {
            var query = "INSERT INTO Venta (Id, IdProducto, Stock, IdVenta)" +
                        "VALUES (@Id,@Comentarios,@IdVenta)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {

                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = ventaCreada.Id });
                    sqlcommand.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = ventaCreada.Comentarios });                    
                    sqlcommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = ventaCreada.IdUsuario });


                    sqlcommand.ExecuteNonQuery();
                }



                connection.Close();


            }


        }
        public static void ModificarVenta(Venta ventaModificada)
        {
            var query = "UPDATE ProductoVendido " +
                        "SET " +
                        "Id = @Id, " +
                        "Comentarios = @Comentarios, " +
                        "IdUsuario = @IdUsuario, " +                        
                        "WHERE ID = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {

                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = ventaModificada.Id });
                    sqlcommand.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = ventaModificada.Comentarios });
                    sqlcommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = ventaModificada.IdUsuario });
                    



                    sqlcommand.ExecuteNonQuery();
                }

                connection.Close();


            }
        }
        public static void EliminarVenta(Venta ventaEliminada)
        {
            var query = "DELETE FROM Venta WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {
                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = ventaEliminada.Id });

                    sqlcommand.ExecuteNonQuery();

                }

                connection.Close();


            }


        }
    }
}
