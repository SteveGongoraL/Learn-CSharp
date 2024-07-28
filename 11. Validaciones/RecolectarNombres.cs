using System;
using System.Collections.Generic;

namespace CSharpValidaciones
{
    static class RecolectarNombres
    {
        static void Main(string[] args)
        {
            // Declarando una lista vacia
            List<string> lstNombresPorValidar = new List<string>();

            // Pedir los nombres que se desean guardar
            Console.WriteLine("Dime tu nombre:");
            lstNombresPorValidar.Add(Console.ReadLine());
            Console.WriteLine("Dime tu apellido paterno:");
            lstNombresPorValidar.Add(Console.ReadLine());
            Console.WriteLine("Dime tu apellido materno:");
            lstNombresPorValidar.Add(Console.ReadLine());

            // Llamar al archivo que hace la validación
            List<string> lstMensajeValidacion = ValidarNombres.validarNombres(lstNombresPorValidar);

            // Validar el mensaje de respuesta
            if(lstMensajeValidacion.Count == 0)
            {}
            else
            {
                Console.WriteLine("\nTu nombre presenta los siguientes errores:");

                // Iterar en la respuesta recibida
                foreach(string mensajeValidacion in lstMensajeValidacion)
                {
                    Console.WriteLine(mensajeValidacion);
                }
            }
        }
    }
}
