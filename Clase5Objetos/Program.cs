using Clase5Objetos;

//private int _codigo;
//double _precioCompra;
//private double _precioVenta;
//private string _categoria;

//Crear una INSTANCIA de la CLASE "Producto" (Objeto / Crear Objeto)
//Un objeto es la instancia de una clase
Producto producto = new Producto();
Producto producto2 = new Producto(1, "Pepsi", 5000, 10000, "Gaseosa");

bool tieneprecio1 = producto.HayPreciodeVenta();
bool tieneprecio2 = producto2.HayPreciodeVenta();


producto2.Descripcion = "Manaos";
producto2.PrecioCompra = 5000;
producto2.PrecioVenta = 10000;
producto2.Codigo = 3;

Console.WriteLine("Codigo: " + producto2.Codigo);
Console.WriteLine("Descripcion: " + producto2.Descripcion);
Console.WriteLine("Precio Compra: " + producto2.PrecioCompra);
Console.WriteLine("Precio Venta: " + producto2.PrecioVenta);
Console.WriteLine("Categoria: " + producto2.Categoria);

Console.ReadKey();



