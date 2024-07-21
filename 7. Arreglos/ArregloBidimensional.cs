using System;
using System.IO;

namespace CSharpArregloBidimensional
{
    class ArregloBidimensional
    {
        static void Main(string[] args)
        {
            // Declarando variables
            int opcionElegida, cantidadValores, matricula;
            bool continuar = true;

            // Inicio de while
            while(continuar)
            {
                Console.WriteLine("\n¿Qué opción quieres escoger?: \n1)-Llenar listado de alumnos. 2)-Salir.");
                opcionElegida = int.Parse(Console.ReadLine());

                // Validar respuesta
                if(opcionElegida == 1)
                {
                    Console.WriteLine("¿Cuantos valores desea agregar?:");
                    cantidadValores = int.Parse(Console.ReadLine());
                    string[,] arregloDosDimensiones = new string[2, cantidadValores];

                    // Llenar el arreglo
                    for(int x = 0; x < cantidadValores; x++)
                    {
                        Console.WriteLine("\n¿Que matricula deseas agregar?: ");
                        matricula = int.Parse(Console.ReadLine());
                        string matriculaString = Convert.ToString(matricula);
                        arregloDosDimensiones[0, x] = matriculaString;
                        Console.WriteLine("\n¿Cual es el nombre que deseas agregar?: ");
                        arregloDosDimensiones[1, x] = Console.ReadLine();
                    }

                    // Mostrar el arreglo bidimensional.
                    Console.WriteLine("\nMatricula - Nombre");
                    for(int y = 0; y < cantidadValores; y++)
                    {
                        Console.WriteLine($"{arregloDosDimensiones[0,y]} - {arregloDosDimensiones[1,y]}");
                    }
                }
                else if(opcionElegida == 2)
                {
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
