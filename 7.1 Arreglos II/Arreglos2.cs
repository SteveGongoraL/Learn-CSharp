using System;
using System.Linq;

namespace CSharpArreglos2
{
    class Arreglos2
    {
        static void Main(string[] args)
        {
            // Declarando variables
            int opcionElegida, cantidadValores;
            bool continuar = true;

            // Inicio de while
            while(continuar)
            {
                Console.WriteLine("\n¿Qué opción quieres escoger?:");
                Console.WriteLine("1)-Unificar Arreglo. 2)-Mayor y menor número. 3)-Quitar duplicados y ordenar ascendente. 4)-Salir.");
                opcionElegida = int.Parse(Console.ReadLine());

                // Validar respuesta
                if(opcionElegida == 1)
                {
                    // Preguntar por la cantidad de valores para asi tener el tamaño del array
                    Console.WriteLine("¿Cuantos valores desea agregar?:");
                    cantidadValores = int.Parse(Console.ReadLine());

                    // Declarar los arreglos vacios
                    string[] nombresArreglo = new string[cantidadValores];
                    string[] apellidosArreglo = new string[cantidadValores];

                    // Llenar el arreglo
                    for(int x = 0; x < cantidadValores; x++)
                    {
                        Console.WriteLine("\n¿Qué nombre quieres agregar?:");
                        nombresArreglo[x] = Console.ReadLine();
                        Console.WriteLine("\n¿Cual es el apellido?:");
                        apellidosArreglo[x] = Console.ReadLine();
                    }

                    // Juntar los arreglos
                    string[] arregloCombinado = nombresArreglo.Concat(apellidosArreglo).ToArray();

                    // Imprimir el arreglo
                    Console.WriteLine("El arreglo completo es: \n");
                    for(int y = 0; y < cantidadValores * 2; y ++)
                    {
                        Console.WriteLine(arregloCombinado[y]);
                    }
                }
                else if(opcionElegida == 2)
                {
                    // Preguntar por la cantidad de valores para asi tener el tamaño del array
                    Console.WriteLine("¿Cuantos valores desea agregar?:");
                    cantidadValores = int.Parse(Console.ReadLine());

                    // Declarar los arreglos vacios
                    int[] numerosArreglo = new int[cantidadValores];

                    // Llenar el arreglo
                    for(int x = 0; x < cantidadValores; x++)
                    {
                        Console.WriteLine("\nIngresa el valor:");
                        numerosArreglo[x] = int.Parse(Console.ReadLine());
                    }

                    // Sacar el valor mayor y el menor
                    Console.WriteLine($"\nEl numero mayor es: {numerosArreglo.Max()} \nEl numero menor es: {numerosArreglo.Min()}");
                }
                else if(opcionElegida == 3)
                {
                    // Preguntar por la cantidad de valores para asi tener el tamaño del array
                    Console.WriteLine("¿Cuantos valores desea agregar?:");
                    cantidadValores = int.Parse(Console.ReadLine());

                    // Declarar los arreglos vacios
                    int[] duplicadosArreglo = new int[cantidadValores];

                    // Llenar el arreglo
                    for(int x = 0; x < cantidadValores; x++)
                    {
                        Console.WriteLine("\nIngresa el numero:");
                        duplicadosArreglo[x] = int.Parse(Console.ReadLine());
                    }

                    // Eliminar duplicados
                    int[] sinDuplicadosArreglo = duplicadosArreglo.Distinct().ToArray();

                    // Ordenar arreglo
                    Array.Sort(sinDuplicadosArreglo);

                    // Imprimir el arreglo
                    Console.WriteLine("\nEl arreglo sin duplicados es:");
                    foreach (var valoresArreglo in sinDuplicadosArreglo)
                    {
                        Console.WriteLine(valoresArreglo);
                    }
                }
                else if(opcionElegida == 4)
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
