// See https://aka.ms/new-console-template for more information
Console.WriteLine("PUNTO 4");

string palabraCompleta = "El gato juega en el jardin";


string palabra1 = "El ";
string palabra2 = " juega ";
string palabra3 = " el ";


string p1 = "gato";
string p2 = "en";
string p3 = "jardin";

bool encontrado1 = false;
bool encontrado2 = false;
bool encontrado3 = false;

string resultadoPalabra = "";


string tp1;
int intentos = 3;

Console.WriteLine("Complete la palabra ");
/* "El _____ juega _____ el _____". */
Console.WriteLine(palabra1 + "____" + palabra2 + "______" + palabra3 + "______");

while (intentos > 0 /* || resultadoPalabra.Equals(palabraCompleta) */)
{
    //Console.WriteLine(intentos);
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese palabra");
    tp1 = Console.ReadLine();

    if ((tp1.Equals(p1) && !encontrado1) || (tp1.Equals(p2) && !encontrado2) || (tp1.Equals(p3) && !encontrado3))
    {
        switch (tp1)
        {
            case "gato":
                encontrado1 = true;
                palabra1 += tp1;
                break;
            case "en":
                encontrado2 = true;
                palabra2 += tp1;
                break;

            case "jardin":
                encontrado3 = true;
                palabra3 += tp1;
                break;


            default:
                Console.WriteLine("No se que paso ");
                break;
        }
        resultadoPalabra = palabra1 + palabra2 + palabra3;
        Console.WriteLine(resultadoPalabra); 
        /* Console.WriteLine(resultadoPalabra.Equals(palabraCompleta));
        */
        //Console.WriteLine(resultadoPalabra);

        if (resultadoPalabra.Equals(palabraCompleta))
        {
            Console.WriteLine("GANO!!!!!!");
            return;
        }
        continue;

    }

    /* resultadoPalabra = palabra1 + palabra2 + palabra3;
    Console.WriteLine(resultadoPalabra.Equals(palabraCompleta));
 */
    intentos--;

    if (encontrado1 || encontrado2 || encontrado3)
    {
        Console.WriteLine("la palabra ya se ingreso");
        Console.WriteLine("le quedan " + intentos + " Intentos\n");
    }
    else
    {
        Console.WriteLine("Palabra incorreta");
        Console.WriteLine("le quedan " + intentos + " Intentos\n");
    }

};



