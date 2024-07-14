using System;

namespace CSharpCondicionalesBucles
{
    class CondionalesBucles
    {
        static void Main(string[] args)
        {
            // Declarando variables
            int opcionElegida;
            decimal numero1, numero2;
            bool continuar = true;
            
            // Bucle WHILE
            while(continuar){
                // Preguntar por la operación a realizar
                Console.WriteLine("¿Qué operación deseas realizar?");
                Console.WriteLine("1) Suma. 2) Resta. 3) Multiplicación. 4) División. 5) Salir.\n");
                opcionElegida = int.Parse(Console.ReadLine());

                // Condicional IF
                if(opcionElegida >= 1 && opcionElegida <= 4)
                {
                    // Preguntando los numeros necesarios
                    Console.WriteLine("Dime el primer numero: ");
                    numero1 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Dime el segundo numero: ");
                    numero2 = decimal.Parse(Console.ReadLine());

                    // Condicional IF
                    if(opcionElegida == 1)
                    {
                        decimal suma = numero1 + numero2;
                        Console.WriteLine ($"La suma es: {suma}\n");
                    }
                    else if(opcionElegida == 2)
                    {
                        decimal resta = numero1 - numero2;
                        Console.WriteLine ($"La resta es: {resta}\n");
                    }
                    else if(opcionElegida == 3)
                    {
                        decimal multiplicacion = numero1 * numero2;
                        Console.WriteLine ($"La multiplicación es: {multiplicacion}\n");
                    }
                    else
                    {
                        decimal division = numero1 / numero2;
                        Console.WriteLine ($"La división es: {division}\n");
                    }
                }
                else if(opcionElegida == 5)
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Debes escoger una opción valida.");
                }
            }
        }
    }
}
