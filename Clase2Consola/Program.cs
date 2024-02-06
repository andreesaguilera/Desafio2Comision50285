// See https://aka.ms/new-console-template for more information


// CONDICIONAL SIMPLE
//Supongamos que debemos hacer un control básico del stock de nuestros productos en un depósito.
//Nos brindan la cantidad de productos en depósito y la cantidad de productos vendidos. Entonces debemos preguntarnos si no existen productos en nuestro depósito, 
//entonces debemos reponerlos.  
//Aquí utilizamos Console.ReadLine() para obtener la cantidad a vender y seguir trabajando con variables, en la cual como dicha función retorna un string 
//y la cantidad es un entero tuvimos que convertir utilizando la función Convert que me permite convertir entre diversos tipos de datos.


// CONDICIONAL COMPUESTO

//Basándonos en el ejemplo anterior debemos preguntarnos si no existen productos en nuestro depósito, entonces debemos reponerlos.  
//De lo contrario, notificar al área de ventas que aún siguen productos sin vender.
//Nótese que solo existe una condición y dos valores posibles.

// ANIDADO

//Basándonos en el ejemplo anterior:
//Se debe informar que no existen productos si no hay.
//En caso de Haber productos
//si  hay 5 o menos notificar a Logística que Se encuentra en los márgenes de Stock Mínimo y se debe reponer y informar a ventas que hay disponibilidad para vender
//caso contrario solo informar a ventas que hay disponibilidad para vender.
//Observar que en este caso tenemos dos condiciones, cantidad == 0 por un lado y cantidad <= 5 por otro lado, noten que ya tendremos en este caso al menos 3 resultados posibles. 



int cantidadProductosVendidos;
int cantidadProductosDeposito = 50;
int stock;

Console.WriteLine("Ingrese cantidad de productos vendidos");

cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());


stock = cantidadProductosDeposito - cantidadProductosVendidos;


if (stock == 0)
{
    Console.WriteLine("Reponer stock de productos");
    //cantidadProductosDeposito = cantidadProductosDeposito + 10;
    cantidadProductosDeposito += 10;
    Console.WriteLine("Productos cargados al deposito");


}
else
{
    if (stock <=5)
    {
        Console.WriteLine("Stock minimo, reponer stock de productos");
        cantidadProductosDeposito += 5;
        Console.WriteLine("Productos cargados al deposito");
        

    }
     
    
        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
    


  

    
}







Console.ReadKey();








