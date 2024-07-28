using System;
using System.Collections.Generic;

namespace CSharpAddPersona
{
    class AddPersona
    {
        static void Main(string[] args)
        {
            // Con valores estaticos
            // Agregando valores a la clase Persona
            List<ClasePersona> lstPersona = new List<ClasePersona>()
            { 
                new ClasePersona {Name = "Steve", Age= 21, Address = "Zaragoza #23"},
                new ClasePersona {Name = "Brayton", Age= 20, Address = "Alameda #897"}
            };

            // Imprimiendo los valores que estan en la lista Persona
            Console.WriteLine("\nVALORES PREDEFINIDOS");
            Console.WriteLine("Valores de las Personas:");
            foreach(ClasePersona registroPersona in lstPersona)
            {
                Console.WriteLine($"Nombre: {registroPersona.Name}");
                Console.WriteLine($"Edad: {registroPersona.Age}");
                Console.WriteLine($"Direccion: {registroPersona.Address}");
            }



            // Con valores variables
            string nombreUsuaio, apellidoPaternoUsuario, apellidoMaternoUsuario;
            int edadUsuario, cantidadValores;
            List<ClaseUsuario> lstUsuario = new List<ClaseUsuario>();

            // Preguntar por la cantidad de usuarios
            Console.WriteLine("\n¿Cuantos usuarios quieres agregar?:");
            cantidadValores = int.Parse(Console.ReadLine());

            for(int x = 0; x < cantidadValores; x ++){
                ClaseUsuario addUsuario = new ClaseUsuario();

                // Preguntar y guardar el NOMBRE
                Console.WriteLine("\n¿Cual es el Nombre que quieres guardar?:");
                addUsuario.Nombre = Console.ReadLine();
                // Preguntar y guardar el APELLIDO PATERNO
                Console.WriteLine("¿Cual es el Apellido Paterno que quieres guardar?:");
                addUsuario.APaterno = Console.ReadLine();
                // Preguntar y guardar el APELLIDO MATERNO
                Console.WriteLine("¿Cual es el Apellido Materno que quieres guardar?:");
                addUsuario.AMaterno = Console.ReadLine();
                // Preguntar y guardar la EDAD
                Console.WriteLine("¿Cual es la Edad que quieres guardar?:");
                addUsuario.Edad = int.Parse(Console.ReadLine());

                // Guardar la información
                lstUsuario.Add(addUsuario);
            }

            // Imprimiendo los valores que estan en la lista Usuarios
            Console.WriteLine("\nVALORES VARIABLES");
            Console.WriteLine("Valores de los Usuarios:");
            foreach (ClaseUsuario registroUsuario in lstUsuario)
            {
                Console.WriteLine($"Nombre: {registroUsuario.Nombre}");
                Console.WriteLine($"Apellido Paterno: {registroUsuario.APaterno}");
                Console.WriteLine($"Apellido Materno: {registroUsuario.AMaterno}");
                Console.WriteLine($"Edad: {registroUsuario.Edad}");
                Console.WriteLine("");
            }
        }
    }
}
