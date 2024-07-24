using System;
using System.IO;

namespace CSharpCalculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            // Declarando variables y arreglos
            string[] historialOperaciones = new string[0];
            int opcionElegida, operacionElegida, cantidadOperaciones, tamanoArreglo, numero1, numero2;
            bool continuar = true;

            while(continuar)
            {
                // Elegir que es lo que se hara
                Console.WriteLine("\n¿Qué deseas realizar?");
                Console.WriteLine("1)-Ingresar a la calculadora. 2)-Ver el historial. 3)-Salir.");
                opcionElegida = int.Parse(Console.ReadLine());

                // Evaluar las opciones
                if(opcionElegida == 1)
                {
                    // Escoger operación
                    Console.WriteLine("\n¿Qué operacion deseas realizar?");
                    Console.WriteLine("1)-Suma. 2)-Resta. 3)-Multiplicación. 4)-División");
                    operacionElegida = int.Parse(Console.ReadLine());

                    //Evaluar que sea una opecion valida
                    if(operacionElegida < 5 && operacionElegida > 0)
                    {
                        // Escoger cuantas operaciones realizar
                        Console.WriteLine("\n¿Cuantas operaciones quieres realizar?:");
                        cantidadOperaciones = int.Parse(Console.ReadLine());

                        // Cambiar el tamaño del arreglo
                        tamanoArreglo = historialOperaciones.Length + cantidadOperaciones;
                        Array.Resize(ref historialOperaciones, tamanoArreglo);

                        // Evalaur operación
                        if(operacionElegida == 1){
                            // Ciclo para pedir los numeros la cantidad de veces que se especifico
                            for(int x = 0; x < cantidadOperaciones; x ++)
                            {
                                Console.WriteLine("\nIngrese el primer valor:");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo valor:");
                                numero2 = int.Parse(Console.ReadLine());

                                // Sumar numeros
                                int sumaNumeros = numero1 + numero2;

                                // Guardar resultado
                                int tamanoVariableArray = historialOperaciones.Length;
                                int posicionFinalArray = tamanoVariableArray - cantidadOperaciones + x;
                                historialOperaciones[posicionFinalArray] = $"Suma: {sumaNumeros}";

                                Console.WriteLine($"\nEl resultado de la suma es: {sumaNumeros}");
                            }
                        }
                        else if(operacionElegida == 2)
                        {
                            // Ciclo para pedir los numeros la cantidad de veces que se especifico
                            for(int x = 0; x < cantidadOperaciones; x ++)
                            {
                                Console.WriteLine("\nIngrese el primer valor:");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo valor:");
                                numero2 = int.Parse(Console.ReadLine());

                                // Restar numeros
                                int restaNumeros = numero1 - numero2;

                                // Guardar resultado
                                int tamanoVariableArray = historialOperaciones.Length;
                                int posicionFinalArray = tamanoVariableArray - cantidadOperaciones + x;
                                historialOperaciones[posicionFinalArray] = $"Resta: {restaNumeros}";

                                Console.WriteLine($"\nEl resultado de la resta es: {restaNumeros}");
                            }
                        }
                        else if(operacionElegida == 3)
                        {
                            // Ciclo para pedir los numeros la cantidad de veces que se especifico
                            for(int x = 0; x < cantidadOperaciones; x ++)
                            {
                                Console.WriteLine("\nIngrese el primer valor:");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo valor:");
                                numero2 = int.Parse(Console.ReadLine());

                                // Multiplicar numeros
                                int multiplicarNumeros = numero1 * numero2;

                                // Guardar resultado
                                int tamanoVariableArray = historialOperaciones.Length;
                                int posicionFinalArray = tamanoVariableArray - cantidadOperaciones + x;
                                historialOperaciones[posicionFinalArray] = $"Multiplicación: {multiplicarNumeros}";

                                Console.WriteLine($"\nEl resultado de la multiplicación es: {multiplicarNumeros}");
                            }
                        }
                        else
                        {
                            // Ciclo para pedir los numeros la cantidad de veces que se especifico
                            for(int x = 0; x < cantidadOperaciones; x ++)
                            {
                                Console.WriteLine("\nIngrese el primer valor:");
                                numero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo valor:");
                                numero2 = int.Parse(Console.ReadLine());

                                // División numeros
                                int divisionNumeros = numero1 / numero2;

                                // Guardar resultado
                                int tamanoVariableArray = historialOperaciones.Length;
                                int posicionFinalArray = tamanoVariableArray - cantidadOperaciones + x;
                                historialOperaciones[posicionFinalArray] = $"División: {divisionNumeros}";

                                Console.WriteLine($"\nEl resultado de la división es: {divisionNumeros}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Debes escoger un numero de operación valida\n");
                    }
                }
                else if(opcionElegida == 2)
                {
                    // Evaluar si existe registro en el historial
                    if(historialOperaciones.Length <= 0)
                    {
                        Console.WriteLine("Debes realizar operaciones para tener el historial\n");
                    }
                    else
                    {
                        Console.WriteLine("\nEl historial de las operaciones es el siguiente:");
                        for(int x = 0; x < historialOperaciones.Length; x ++)
                        {
                            Console.WriteLine(historialOperaciones[x]);
                        }
                    }
                }
                else if(opcionElegida == 3)
                {
                    // Comprobar si existe historial
                    if(historialOperaciones.Length > 0)
                    {
                        // Guardar historial en un TXT
                        StreamWriter sw = new StreamWriter(".\\docs\\Historial.txt");
                        sw.WriteLine("Los resultados fueron los siguientes:\n");
                        // Recorrer el arreglo para imprimir los valores
                        for(int x = 0; x < historialOperaciones.Length; x ++)
                        {
                            sw.WriteLine(historialOperaciones[x]);
                        }
                        sw.Close();
                        Console.WriteLine("\nEl historial se guardo en la carpeta docs");
                    }

                    Console.WriteLine("\nPrograma terminado");

                    // Romper el ciclo
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("\nDebes escoger una opció valida");
                }
            }
        }
    }
}
