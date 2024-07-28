using System;
using System.IO;

namespace CSharpNumerosPares
{
    class NumerosPares
    {
        static void Main(string[] args)
        {
            // Declarando una lista vacia y una variable
            List<int> lstNumeros = new List<int>();
            int cantidadNumeros = 0;

            // Preguntar por la cantidad de valores
            Console.WriteLine("¿Cuantos numeros quieres guardar?: ");
            cantidadNumeros = int.Parse(Console.ReadLine());

            // Ciclo FOR para guardar los numeros en la lista
            for(int x = 1; x <= cantidadNumeros; x ++)
            {
                Console.WriteLine("Ingresa el numero: ");
                lstNumeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Imprimiendo los numeros pares
            Console.WriteLine("Lista de numeros pares:\n");
            foreach(int x in lstNumeros)
            {
                if(x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
