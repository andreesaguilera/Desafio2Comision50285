using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase9ADOnetFORM
{
    public partial class ListadoProducto : Form
    {
        public ListadoProducto()
        {
            InitializeComponent();
        }

        private void ListadoProducto_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEDARKIS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            List<Producto> listaProductos = new List<Producto>();

            var query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario from Producto;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Instancio objeto
                                    var producto = new Producto();

                                    // Seteo variables del objeto
                                    producto.Id = Convert.ToInt32(reader["Id"]);
                                    producto.Descripciones = Convert.ToString(reader["Descripciones"]);
                                    producto.Costo = Convert.ToDouble(reader["Costo"]);
                                    producto.PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(reader["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);

                                    // Agrego objeto a la lista
                                    listaProductos.Add(producto);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex) 
                { 
                Console.WriteLine(ex.Message);
                }   
                

            }

            // Agrego lista al datagridview
            dataGridView1.DataSource = listaProductos;

            // Seteo autogeneracion de columnas
            dataGridView1.AutoGenerateColumns = true;
        }
    }
}
