using System;
using System.IO;

namespace CSharpFibonacciDivisas
{
    class FibonacciDivisas
    {
        static void Main(string[] args)
        {
            // Declarando variables
            int opcionElegida, a = 0, b = 1, aux, x, lim;
            double valor1,t1=0, t2=0, t3=0, t4=0, canadiense = 0.062, yen = 5.40, euro = 0.042, libra = 0.036;
            bool continuar = true;

            // Bucle WHILE
            while(continuar){
                // Preguntar por la operación a realizar
                Console.WriteLine("\nBienvenido, ¿Qué operación desea realizar?:");
                Console.WriteLine("1)-Serie Fibonacci. 2)-Calculadora de Divisas. 3)-Salir");
                opcionElegida = int.Parse(Console.ReadLine());

                if(opcionElegida == 1)
                {
                    // Abrir TXT
                    StreamWriter sw = new StreamWriter(".\\docs\\Serie Fibonacci.txt");
                    sw.WriteLine("Problema 4 Serie Fibonacci");
                    // Pedir valores
                    Console.WriteLine("¿Cuantos numeros de Fibonacci desea que se muestren?: ");
                    lim= int.Parse(Console.ReadLine());
                    for(x=0; x<lim; x++){
                        if(x==0){
                            Console.Write(a + " ");
                            sw.WriteLine(a);
                        }
                        else{
                            aux=a;
                            a=b;
                            b=aux+a;
                            Console.Write(a + " ");
                            sw.WriteLine(a);
                        }
                    }
                    Console.WriteLine("\nPerfección");
                    Console.WriteLine("El resultado se guardo exitosamente en un archivo txt.");
                    sw.Close();
                }
                else if(opcionElegida == 2)
                {
                    // Pedir la cantidad
                    Console.WriteLine("\n¿Cual es la cantidad que deseas convertir?");
                    valor1 = double.Parse(Console.ReadLine());
                    // Pedir la moneda a la que lo quieren convertir
                    Console.WriteLine("¿A que valor divisa desea convertirlo?");
                    Console.WriteLine("1)-Dolar Canadiense. 2)-Yen. 3)-Euro. 4)-Libra Esterlina.");
                    opcionElegida = int.Parse(Console.ReadLine());

                    if(opcionElegida == 1)
                    {
                        t1 = canadiense * valor1;
                        Console.WriteLine("La divisa en dolares canadienses es: " + t1);
                    }
                    else if (opcionElegida == 2)
                    {
                        t2 = yen * valor1;
                        Console.WriteLine("La divisa en yen es: " + t2);
                    }
                    else if (opcionElegida == 3)
                    {
                        t3 = euro * valor1;
                        Console.WriteLine("La divisa en euro es: " + t3);
                    }
                    else if (opcionElegida == 4)
                    {
                        t4 = libra * valor1;
                        Console.WriteLine("La divisa en Libra Esterlina es: " + t4);
                    }
                    else
                    {
                        Console.WriteLine("Escoje una divisa valida");
                    }

                    // Guardar en TXT
                    StreamWriter sw = new StreamWriter(".\\docs\\Resultado Divisas.txt");
                    sw.WriteLine("El resultado de las divisas seleccionadas es la siguiente:");
                    if(t1 != 0)
                    {
                        sw.WriteLine($"\nDÓLARES CANADIENSES \nCantidad en Pesos Mexicanos: {valor1} \nLa divisa en dolares canadienses es: {t1}");
                    }
                    if(t2 != 0)
                    {
                        sw.WriteLine($"\nYEN \nCantidad en Pesos Mexicanos: {valor1} \nLa divisa en Yen es: {t2}");
                    }
                    if(t3 != 0)
                    {
                        sw.WriteLine($"\nEURO \nCantidad en Pesos Mexicanos: {valor1} \nLa divisa en Euro es: {t3}");
                    }
                    if(t4 != 0)
                    {
                        sw.WriteLine($"\nLIBRA ESTERLINA \nCantidad en Pesos Mexicanos: {valor1} \nLa divisa en Libra Esterlina es: {t4}");
                    }
                    sw.Close();
                    Console.WriteLine("\nEl resultado se guardo exitosamente en un archivo txt.");
                }
                else if(opcionElegida == 3)
                {
                    Console.WriteLine("Fin del programa");
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Debes escoger una opción valida");
                }
            }
        }
    }
}