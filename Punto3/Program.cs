// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string num;
int sumaDigitos = 0;
int numero;

Console.WriteLine("Ingrese Numero:");
num = Console.ReadLine();
numero = Int32.Parse(num);

if (numero % 5 == 0 && (numero % 2 != 0 || numero % 3 != 0))
{

    foreach (var item in num)
    {
        //Console.WriteLine(item);
        sumaDigitos += (int)Char.GetNumericValue(item);
    }

    if (sumaDigitos > 10)
    {
        Console.WriteLine("Numero especial");
        return;
    }
    return;
}

Console.WriteLine("no es especial  ");

/*  if (numero % 5 != 0 && (numero % 2 == 0 || numero % 3 ==0))
{
    Console.WriteLine("No cumple las condiciones ");
    return;
} 
 */
//Console.WriteLine("\nLa suma de los digitos es: " + sumaDigitos);