using ProjectTest;
using System.Security.Authentication;

Usuario usuario = new Usuario(1992, "Luciano Federico", "Martinez", "Luchjto", "casa74109630", "Luchofmartinez@gmail.com");

Producto producto = new Producto(0001, "Gorra", 5000, 3000, 15, 1990 );

ProductoVendido productoVendido = new ProductoVendido(1250, 0001, 15, 0550);

Venta venta = new Venta(0404, "Que linda gorra, recomendable!!", 2991);

Console.WriteLine("Usuario: " + usuario.Nombre +" "+  usuario.Apellido);
Console.WriteLine("Producto que compro: " + producto.Descripcion);
Console.WriteLine("Valor del producto: " + producto.Costo);
Console.WriteLine("Stock disponible: " + productoVendido.Stock);
Console.WriteLine("Comentarios acerca del producto: " + venta.Comentarios);




