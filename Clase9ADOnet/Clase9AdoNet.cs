using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Clase9ADOnet
{
    public class Clase9AdoNet
    {
        static void Main(string[] args)

        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"; //Connection String o Cadena de conexion


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Abro la conexion
                connection.Open();


                //Creamos el comando a ejecutar
                using (SqlCommand command = new SqlCommand("Select * from USUARIOS", connection))


                //Creamos el dataReader y ejecuto el metodo ExecuteReader para recuperar los datos
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    //Pregunto si la base de datos me devolvio columnas
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            var datoAUsar = reader.GetString(1);

                            //Aca debo trabajar con el dato a usar
                        }
                    }


                        connection.Close();


                Console.ReadKey();

            }

        }

        }
    }

}
    

