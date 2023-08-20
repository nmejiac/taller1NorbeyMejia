// See https://aka.ms/new-console-template for more information
Console.WriteLine("Punto 1");

/* 
Objetivo: Crear una calculadora que maneje fracciones. 
El usuario ingresará dos fracciones y un operador.
La calculadora deberá realizar la operación. 
Debes manejar sumas, restas, multiplicaciones y divisiones. 
Si el usuario intenta dividir entre cero, deberás mostrar un mensaje de error.
 */


int opc;
int numerador1;
int denominador1;
string operacion;
int numerador2;
int denominador2;

int resNumerador;
int resDenominador;


string res = "";
//bool encontrado = false;



Console.Clear();

do
{
    Console.WriteLine("Seleccione\n 1. Realizar operación\n 2. Mostrar la última operación realizada\n 3. Salir\n ");
    opc = Int32.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            Console.WriteLine("Para Ingresar la Fracion debe ingresar primero en numerador y luego el denominador ");

            Console.WriteLine("Primera Fraccion\n");
            Console.WriteLine("\nIngrese Numerador  ");
            numerador1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese Denominador  ");
            denominador1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nSegunda Fraccion\n");
            Console.WriteLine("\nIngrese Numerador  ");
            numerador2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese Denominador  ");
            denominador2 = Int32.Parse(Console.ReadLine());
            if (denominador1 == 0 || denominador2 == 0)
            {
                Console.WriteLine("El denominador no puede ser 0");
                break;
            }

            Console.WriteLine("\nSeleccione\n +. Para sumar\n -. Para Restar\n /. Para dividir\n *. Para Multiplicar\n");
            operacion = Console.ReadLine();



            switch (operacion)
            {
                case "+":
                    int i = 1;
                    resNumerador = (numerador1 * denominador2) + (numerador2 * denominador1);
                    resDenominador = denominador1 * denominador2;
                    res = numerador1 + "/" + denominador1 + "  /  " + numerador2 + "/" + denominador2 + "  =  " + resNumerador + "/" + resDenominador;
                    Console.WriteLine(res);
                    /*  
                                        while (encontrado)
                                        {
                                            if (i % numerador1 == 0 && i % numerador1 == 0)
                                            {
                                                resDenominador = i;
                                                resNumerador = (numerador1 * denominador2) + (numerador2 * denominador1);
                                                res = numerador1 + "/" + denominador1 + "  /  " + numerador2 + "/" + denominador2 + "  =  " + resNumerador + "/" + resDenominador;
                                                Console.WriteLine(res);
                                                encontrado = true;                            
                                            }
                                            i++;
                                        } */

                    break;

                case "-":
                    //resultado = num1 - num2;
                    resNumerador = (numerador1 * denominador2) - (numerador2 * denominador1);
                    resDenominador = denominador1 * denominador2;
                    res = numerador1 + "/" + denominador1 + "  /  " + numerador2 + "/" + denominador2 + "  =  " + resNumerador + "/" + resDenominador;
                    Console.WriteLine(res);
                    break;

                case "/":

                    Console.WriteLine("Aqui se realizara la Divicion");

                    resNumerador = numerador1 * denominador2;
                    resDenominador = numerador2 * denominador1;
                    //Console.WriteLine("Resultado " + resultado);
                    res = numerador1 + "/" + denominador1 + "  /  " + numerador2 + "/" + denominador2 + "  =  " + resNumerador + "/" + resDenominador;
                    Console.WriteLine(res);
                    /*                    if (num2 == 0)
                                       {
                                           Console.WriteLine("el denominador no puede ser 0 ");
                                           break;
                                       }
                                       resultado = num1 / num2;
                                       res = num1 + " / " + num2 + " = " + resultado;
                                       Console.WriteLine(res); */
                    break;

                case "*":
                    resNumerador = numerador1 * numerador2;
                    resDenominador = denominador1 * denominador2;
                    //Console.WriteLine("Resultado " + resultado);
                    res = numerador1 + "/" + denominador1 + "  /  " + numerador2 + "/" + denominador2 + "  =  " + resNumerador + "/" + resDenominador;
                    Console.WriteLine(res);
                    break;

                default:
                    Console.WriteLine("Opcion Invalida ");
                    break;
            }
            break;

        case 2:
            if (res == "")
            {
                Console.WriteLine("no se a realizado ninguna operacion ");
                break;
            }
            Console.WriteLine(res);
            break;

        case 3:
            Console.WriteLine("Saliendo...");
            break;


        default:
            Console.WriteLine("opcion Invalida");
            break;
    }

} while (opc != 3);

Console.WriteLine("Salio");