using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Desafio2Comision50285
{
    public static class UsuarioData
    {
        private static string connectionString;

        static UsuarioData()
        {
            connectionString = "Data Source=NEDARKIS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = new Usuario();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USUARIO WHERE Id=@Id;";
                SqlCommand sqlcommand = new SqlCommand(query, connection);
                sqlcommand.Parameters.AddWithValue("Id", id);
               
                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    
                    usuario.Id = Convert.ToInt32(reader["Id"]);
                    usuario.Nombre = reader["Nombre"].ToString();
                    usuario.Apellido = reader["Apellido"].ToString();
                    usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                    usuario.Contrasenia = reader["Contrasenia"].ToString();
                    usuario.Mail = reader["Mail"].ToString();

                   
                }
            }

            return usuario;


        }
        public static List<Usuario> ListarUsuario()
        {
            List<Usuario> listarUsuario = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USUARIO;";
                SqlCommand sqlcommand = new SqlCommand(query, connection);
                
                connection.Open();

                SqlDataReader reader = sqlcommand.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(reader["Id"]);
                    usuario.Nombre = reader["Nombre"].ToString();
                    usuario.Apellido = reader["Apellido"].ToString();
                    usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                    usuario.Contrasenia = reader["Contrasenia"].ToString();
                    usuario.Mail = reader["Mail"].ToString();

                    listarUsuario.Add(usuario);
                     
                                       

                }
                return listarUsuario;
            }

                    
        }
        public static void CrearUsuario(Usuario usuario)
        {
            var query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contrasenia,Mail)" +
                        "VALUES (@Nombre,@Apellido,@NombreUsuario,@Contrasenia,@Mail)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {
                    
                    sqlcommand.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    sqlcommand.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    sqlcommand.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    sqlcommand.Parameters.Add(new SqlParameter("Contrasenia", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                    sqlcommand.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                    sqlcommand.ExecuteNonQuery();
                }

                

                connection.Close();
                                         
                                                
            }


        }
        public static void ModificarUsuario(Usuario usuario)
        {
            var query = "UPDATE USUARIO " +
                        "SET " +
                        "Nombre = @Nombre, " +
                        "Apellido = @Apellido, " +
                        "NombreUsuario = @NombreUsuario, " +
                        "Contrasenia = @Contrasenia, " +
                        "Mail = @Mail " +
                        "WHERE ID = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {
                    
                    sqlcommand.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    sqlcommand.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    sqlcommand.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    sqlcommand.Parameters.Add(new SqlParameter("Contrasenia", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                    sqlcommand.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });

                    sqlcommand.ExecuteNonQuery();
                }

                connection.Close();


            }


        }
        public static void EliminarUsuario(Usuario usuario)
        {
            var query = "DELETE FROM USUARIO WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                {
                    sqlcommand.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });

                    sqlcommand.ExecuteNonQuery();

                }

                connection.Close();


            }


        }


    }











}   



          






















































































































    


        












