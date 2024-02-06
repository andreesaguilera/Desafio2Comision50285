int num1 = 0;
int num2 = 0;

Console.WriteLine("Ingrese primer numero ");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero ");

num2 = Convert.ToInt32(Console.ReadLine());

saludar();


Console.WriteLine("La suma es " + sumar(num1, num2));

int sumar(int num1, int num2)
{
    return (num1 + num2);
}

Console.ReadKey();

void saludar()

{
    Console.WriteLine("Hola soy una funcion");
}
