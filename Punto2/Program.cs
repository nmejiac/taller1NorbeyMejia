// See https://aka.ms/new-console-template for more information
Console.WriteLine("Punto 2");

/* 
Objetivo: El usuario proporcionará un rango (por ejemplo, del 3 al 7). 
El programa generará tablas de multiplicar para cada número en ese rango.
Por ejemplo, si el rango es del 3 al 5,
el programa generará la tabla del 3, la tabla del 4 y la tabla del 5. 
Sin embargo, existe un giro: para cada tabla,
el programa ocultará aleatoriamente uno de los resultados y desafió al usuario a completarlo.
Por ejemplo, "3 x ? = 21" y el usuario debe adivinar que el número faltante es 7.
 */

int inic_rango;
int fin_rango;


Console.WriteLine("Ingrese numero desde que el inicia el Rango ");
inic_rango = Int32.Parse(Console.ReadLine());


Console.WriteLine("Ingrese numero en el que finaliza el Rango ");
fin_rango = Int32.Parse(Console.ReadLine());


for (int i = inic_rango; i <= fin_rango; i++)
{

    int min = 1;
    int max = 10;
    int oculto;
    int valor = 0;


    Random rnd = new Random();
    oculto = rnd.Next(min, max + 1);

    Console.WriteLine("\n tabla del " + i);
    for (int j = 1; j <= 10; j++)
    {
        int result;
        result = i * j;

        if (j == oculto)
        {
            Console.WriteLine("--> " + i + " * " + "?" + " = " + result);
            continue;
        }
        Console.WriteLine("--> " + i + " * " + j + " = " + result);
    }

    while (valor != oculto)
    {
        Console.WriteLine("Cual es el numero que fatla? ");
        valor = Int32.Parse(Console.ReadLine());
        Console.WriteLine("No Paso");
    }
    
    Console.WriteLine("Paso");
    /*  continue; */

}

