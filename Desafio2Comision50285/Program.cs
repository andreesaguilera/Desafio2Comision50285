
using System;
using System.Linq.Expressions;

namespace Desafio2Comision50285;
internal class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            try
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1- ObtenerUsuario");
                Console.WriteLine("2- ListarUsuarios");
                Console.WriteLine("3- CrearUsuario");
                Console.WriteLine("4- ModificarUsuario");
                Console.WriteLine("5- EliminarUsuario");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("6- ObtenerProducto");
                Console.WriteLine("7- ListarProductos");
                Console.WriteLine("8- CrearProducto");
                Console.WriteLine("9- ModificarProducto");
                Console.WriteLine("10- EliminarProducto");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("11- ObtenerProductoVendido");
                Console.WriteLine("12- ListarProductoVendidos");
                Console.WriteLine("13- CrearProductoVendido");
                Console.WriteLine("14- ModificarProductoVendido");
                Console.WriteLine("15- EliminarProductoVendido");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("16- ObtenerVenta");
                Console.WriteLine("17- ListarVentass");
                Console.WriteLine("18- CrearVenta");
                Console.WriteLine("19- ModificarVenta");
                Console.WriteLine("20- EliminarVenta");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Ingrese el numero del metodo a utilizar:");




                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Para obtener usuario ingresar Id: ");

                        string idString = Console.ReadLine();
                        int Id = Convert.ToInt32(idString);


                        Usuario usuario = UsuarioData.ObtenerUsuario(Id);

                        Console.WriteLine(usuario.Nombre);
                        Console.WriteLine(usuario.Apellido);
                        Console.WriteLine(usuario.NombreUsuario);
                        Console.WriteLine(usuario.Contrasenia);
                        Console.WriteLine(usuario.Mail);

                        Console.WriteLine("");
                        break;
                    case 2:
                        List<Usuario> listarUsuario = UsuarioData.ListarUsuario();

                        foreach (Usuario usuarioLista in listarUsuario)
                        {

                            Console.WriteLine("Nombre: " + usuarioLista.Nombre);
                            Console.WriteLine("Apellido: " + usuarioLista.Apellido);
                            Console.WriteLine("NombreUsuario: " + usuarioLista.NombreUsuario);
                            Console.WriteLine("Contrasenia: " + usuarioLista.Contrasenia);
                            Console.WriteLine("Mail: " + usuarioLista.Mail);

                            Console.WriteLine("");

                        }
                        break;
                    case 3:
                        Usuario usuarioCreado = new Usuario();

                        Console.WriteLine("Ingrese Nombre: ");
                        usuarioCreado.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido: ");
                        usuarioCreado.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese NombreUsuario: ");
                        usuarioCreado.NombreUsuario = Console.ReadLine();
                        Console.WriteLine("Ingrese Contrasenia: ");
                        usuarioCreado.Contrasenia = Console.ReadLine();
                        Console.WriteLine("Ingrese Mail: ");
                        usuarioCreado.Mail = Console.ReadLine();

                        UsuarioData.CrearUsuario(usuarioCreado);


                        break;
                    case 4:
                        Usuario usuarioModificado = new Usuario();
                        Console.WriteLine("Ingrese Id a modificar: ");
                        usuarioModificado.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre a modificar: ");
                        usuarioModificado.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido a modificar: ");
                        usuarioModificado.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese NombreUsuario a modificar: ");
                        usuarioModificado.NombreUsuario = Console.ReadLine();
                        Console.WriteLine("Ingrese Contrasenia a modificar: ");
                        usuarioModificado.Contrasenia = Console.ReadLine();
                        Console.WriteLine("Ingrese Mail a modificar: ");
                        usuarioModificado.Mail = Console.ReadLine();

                        UsuarioData.ModificarUsuario(usuarioModificado);

                        break;
                    case 5:
                        Usuario usuarioEliminado = new Usuario();
                        Console.WriteLine("Ingrese Id a eliminar: ");
                        usuarioEliminado.Id = Convert.ToInt32(Console.ReadLine());

                        UsuarioData.EliminarUsuario(usuarioEliminado);
                        break;
                    case 6:
                        Console.WriteLine("Para obtener Producto ingresar IdProducto: ");

                        string idString2 = Console.ReadLine();
                        int Id2 = Convert.ToInt32(idString2);


                        Producto producto = ProductoData.ObtenerProducto(Id2);

                        Console.WriteLine(producto.IdProducto);
                        Console.WriteLine(producto.Descripcion);
                        Console.WriteLine(producto.Costo);
                        Console.WriteLine(producto.PrecioVenta);
                        Console.WriteLine(producto.Stock);
                        Console.WriteLine(producto.IdUsuario);

                        Console.WriteLine("");
                        break;
                    case 7:
                        List<Producto> listarProducto = ProductoData.ListaProductos();

                        foreach (Producto productoLista in listarProducto)
                        {

                            Console.WriteLine("IdProducto: " + productoLista.IdProducto);
                            Console.WriteLine("Descripcion: " + productoLista.Descripcion);
                            Console.WriteLine("Costo: " + productoLista.Costo);
                            Console.WriteLine("PrecioVenta: " + productoLista.PrecioVenta);
                            Console.WriteLine("Stock: " + productoLista.Stock);
                            Console.WriteLine("IdUsuario: " + productoLista.IdUsuario);

                            Console.WriteLine("");

                        }
                        break;
                    case 8:
                        Producto producto1 = new Producto();

                        Console.WriteLine("Ingrese IdProducto: ");
                        producto1.IdProducto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Descripcion: ");
                        producto1.Descripcion = Console.ReadLine();
                        Console.WriteLine("Ingrese Costo: ");
                        producto1.Costo = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese PrecioVenta: ");
                        producto1.PrecioVenta = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese Stock: ");
                        producto1.Stock = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese IdUsuario: ");
                        producto1.IdUsuario = Convert.ToInt32(Console.ReadLine());


                        ProductoData.CrearProducto(producto1);


                        break;
                    case 9:
                        Producto productoModificado = new Producto();
                        Console.WriteLine("Ingrese IdProducto a modificar: ");
                        var idProducto = Console.ReadLine();
                        productoModificado.IdProducto = Convert.ToInt32(idProducto);
                        Console.WriteLine("Ingrese Descripcion a modificar: ");
                        productoModificado.Descripcion = Console.ReadLine();
                        Console.WriteLine("Ingrese Costo a modificar: ");
                        productoModificado.Costo = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese PrecioVenta a modificar: ");
                        productoModificado.PrecioVenta = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese Stock a modificar: ");
                        productoModificado.Stock = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese IdUsuario a modificar: ");
                        productoModificado.IdUsuario = Convert.ToInt32(Console.ReadLine());

                        ProductoData.ModificarProducto(productoModificado);

                        break;
                    case 10:
                        Producto productoEliminado = new Producto();
                        Console.WriteLine("Ingrese IdProducto a eliminar: ");
                        productoEliminado.IdProducto = Convert.ToInt32(Console.ReadLine());

                        ProductoData.EliminarProducto(productoEliminado);
                        break;
                    //case 11:
                    //    Console.WriteLine("Obtener ProductoVendido ingresar Id: ");

                    //    string idString3 = Console.ReadLine();
                    //    int Id3 = Convert.ToInt32(idString3);


                    //    Usuario usuario = UsuarioData.ObtenerUsuario(Id3);

                    //    Console.WriteLine(usuario.Nombre);
                    //    Console.WriteLine(usuario.Apellido);
                    //    Console.WriteLine(usuario.NombreUsuario);
                    //    Console.WriteLine(usuario.Contrasenia);
                    //    Console.WriteLine(usuario.Mail);

                    //    Console.WriteLine("");
                    //    break;
                    //case 12:
                    //    List<Usuario> listarUsuario = UsuarioData.ListarUsuario();

                    //    foreach (Usuario usuarioLista in listarUsuario)
                    //    {

                    //        Console.WriteLine("Nombre: " + usuarioLista.Nombre);
                    //        Console.WriteLine("Apellido: " + usuarioLista.Apellido);
                    //        Console.WriteLine("NombreUsuario: " + usuarioLista.NombreUsuario);
                    //        Console.WriteLine("Contrasenia: " + usuarioLista.Contrasenia);
                    //        Console.WriteLine("Mail: " + usuarioLista.Mail);

                    //        Console.WriteLine("");

                    //    }
                    //    break;
                    //case 13:
                    //    Usuario usuarioCreado = new Usuario();

                    //    Console.WriteLine("Ingrese Nombre: ");
                    //    usuarioCreado.Nombre = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Apellido: ");
                    //    usuarioCreado.Apellido = Console.ReadLine();
                    //    Console.WriteLine("Ingrese NombreUsuario: ");
                    //    usuarioCreado.NombreUsuario = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Contrasenia: ");
                    //    usuarioCreado.Contrasenia = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Mail: ");
                    //    usuarioCreado.Mail = Console.ReadLine();

                    //    UsuarioData.CrearUsuario(usuarioCreado);


                    //    break;
                    //case 14:
                    //    Usuario usuarioModificado = new Usuario();
                    //    Console.WriteLine("Ingrese Id a modificar: ");
                    //    usuarioModificado.Id = Convert.ToInt32(Console.ReadLine());
                    //    Console.WriteLine("Ingrese Nombre a modificar: ");
                    //    usuarioModificado.Nombre = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Apellido a modificar: ");
                    //    usuarioModificado.Apellido = Console.ReadLine();
                    //    Console.WriteLine("Ingrese NombreUsuario a modificar: ");
                    //    usuarioModificado.NombreUsuario = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Contrasenia a modificar: ");
                    //    usuarioModificado.Contrasenia = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Mail a modificar: ");
                    //    usuarioModificado.Mail = Console.ReadLine();

                    //    UsuarioData.ModificarUsuario(usuarioModificado);

                    //    break;
                    //case 15:
                    //    Usuario usuarioEliminado = new Usuario();
                    //    Console.WriteLine("Ingrese Id a eliminar: ");
                    //    usuarioEliminado.Id = Convert.ToInt32(Console.ReadLine());

                    //    UsuarioData.EliminarUsuario(usuarioEliminado);
                    //    break;
                    //case 16:
                    //    Console.WriteLine("Obtener usuario ingresar Id: ");

                    //    string idString = Console.ReadLine();
                    //    int Id = Convert.ToInt32(idString);


                    //    Usuario usuario = UsuarioData.ObtenerUsuario(Id);

                    //    Console.WriteLine(usuario.Nombre);
                    //    Console.WriteLine(usuario.Apellido);
                    //    Console.WriteLine(usuario.NombreUsuario);
                    //    Console.WriteLine(usuario.Contrasenia);
                    //    Console.WriteLine(usuario.Mail);

                    //    Console.WriteLine("");
                    //    break;
                    //case 17:
                    //    List<Usuario> listarUsuario = UsuarioData.ListarUsuario();

                    //    foreach (Usuario usuarioLista in listarUsuario)
                    //    {

                    //        Console.WriteLine("Nombre: " + usuarioLista.Nombre);
                    //        Console.WriteLine("Apellido: " + usuarioLista.Apellido);
                    //        Console.WriteLine("NombreUsuario: " + usuarioLista.NombreUsuario);
                    //        Console.WriteLine("Contrasenia: " + usuarioLista.Contrasenia);
                    //        Console.WriteLine("Mail: " + usuarioLista.Mail);

                    //        Console.WriteLine("");

                    //    }
                    //    break;
                    //case 18:
                    //    Usuario usuarioCreado = new Usuario();

                    //    Console.WriteLine("Ingrese Nombre: ");
                    //    usuarioCreado.Nombre = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Apellido: ");
                    //    usuarioCreado.Apellido = Console.ReadLine();
                    //    Console.WriteLine("Ingrese NombreUsuario: ");
                    //    usuarioCreado.NombreUsuario = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Contrasenia: ");
                    //    usuarioCreado.Contrasenia = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Mail: ");
                    //    usuarioCreado.Mail = Console.ReadLine();

                    //    UsuarioData.CrearUsuario(usuarioCreado);


                    //    break;
                    //case 19:
                    //    Usuario usuarioModificado = new Usuario();
                    //    Console.WriteLine("Ingrese Id a modificar: ");
                    //    usuarioModificado.Id = Convert.ToInt32(Console.ReadLine());
                    //    Console.WriteLine("Ingrese Nombre a modificar: ");
                    //    usuarioModificado.Nombre = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Apellido a modificar: ");
                    //    usuarioModificado.Apellido = Console.ReadLine();
                    //    Console.WriteLine("Ingrese NombreUsuario a modificar: ");
                    //    usuarioModificado.NombreUsuario = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Contrasenia a modificar: ");
                    //    usuarioModificado.Contrasenia = Console.ReadLine();
                    //    Console.WriteLine("Ingrese Mail a modificar: ");
                    //    usuarioModificado.Mail = Console.ReadLine();

                    //    UsuarioData.ModificarUsuario(usuarioModificado);

                    //    break;
                    //case 20:
                    //    Usuario usuarioEliminado = new Usuario();
                    //    Console.WriteLine("Ingrese Id a eliminar: ");
                    //    usuarioEliminado.Id = Convert.ToInt32(Console.ReadLine());

                    //    UsuarioData.EliminarUsuario(usuarioEliminado);
                    //    break;

                }
                Console.WriteLine("Desea continuar? Si/No");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "si")
                    continuar = true;
                if (respuesta.ToLower() == "no")
                    continuar = false;
            }
            catch (Exception ex)
            {

                Console.WriteLine (ex.Message);
            }

            
        }
        
















        
                
    }
}