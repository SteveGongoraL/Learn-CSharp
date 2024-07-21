using System;
using System.IO;

namespace CSharpTiendaAbarrotes
{
    class TiendaAbarrotes
    {
        static void Main(string[] args)
        {
            // Declarando variables
            int opcionElegida, productoElegido, cantidadProducto;
            int precioFrituras = 9, precioRefresco = 8, precioJugo = 5, precioGalletas = 10, precioChicles = 4;
            int totalFrituras = 0, totalRefresco = 0, totalJugo = 0, totalGalletas = 0, totalChicles = 0, cuentaTotal = 0;
            bool continuar = true;

            Console.WriteLine("\nBienvenido a abarrotes Learn-CSharp");
            // Inicio de while
            while(continuar)
            {
                Console.WriteLine("\n¿Qué deseas realizar?:");
                Console.WriteLine("1)-Comprar un producto. 2)-Salir.");
                opcionElegida = int.Parse(Console.ReadLine());

                // Validar decisión
                if(opcionElegida == 1)
                {
                    // Elegir el producto
                    Console.WriteLine("\nEsta es nuestra variedad de productos, seleccione la que desee:");
                    Console.WriteLine("1)-Frituras $9 \n2)-Refresco $8 \n3)-Jugo $5 \n4)-Galletas $10 \n5)-Chicles $4");
                    productoElegido = int.Parse(Console.ReadLine());

                    // Elegir la cantidad y hacer el total del producto
                    if(productoElegido == 1)
                    {
                        Console.WriteLine("\nFRITURAS --- $9.0");
                        Console.WriteLine("¿Cuantas frituras vas a querer?:");
                        cantidadProducto = int.Parse(Console.ReadLine());
                        totalFrituras += precioFrituras * cantidadProducto;
                    }
                    else if(productoElegido == 2)
                    {
                        Console.WriteLine("\nREFRESCO --- $8.0");
                        Console.WriteLine("¿Cuantos refrescos vas a querer?:");
                        cantidadProducto = int.Parse(Console.ReadLine());
                        totalRefresco += precioRefresco * cantidadProducto;
                    }
                    else if(productoElegido == 3)
                    {
                        Console.WriteLine("\nJUGO --- $5.0");
                        Console.WriteLine("¿Cuantos jugos vas a querer?:");
                        cantidadProducto = int.Parse(Console.ReadLine());
                        totalJugo += precioJugo * cantidadProducto;
                    }
                    else if(productoElegido == 4)
                    {
                        Console.WriteLine("\nGALLETAS --- $10.0");
                        Console.WriteLine("¿Cuantas galletas vas a querer?:");
                        cantidadProducto = int.Parse(Console.ReadLine());
                        totalGalletas += precioGalletas * cantidadProducto;
                    }
                    else if(productoElegido == 5)
                    {
                        Console.WriteLine("\nCHICLES --- $4.0");
                        Console.WriteLine("¿Cuantos chicles vas a querer?:");
                        cantidadProducto = int.Parse(Console.ReadLine());
                        totalChicles += precioChicles * cantidadProducto;
                    }
                    else
                    {
                        Console.WriteLine("Debes escoger un producto valido");
                    }
                }
                else if(opcionElegida == 2){
                    Console.WriteLine("\n----------Gracias por su preferencia----------\n");
                    // Diccionario para guardar los totales
                    var productos = new Dictionary<string, (int cantidad, int precio)>
                    {
                        { "frituras", (totalFrituras, precioFrituras) },
                        { "refresco", (totalRefresco, precioRefresco) },
                        { "jugo", (totalJugo, precioJugo) },
                        { "galletas", (totalGalletas, precioGalletas) },
                        { "chicles", (totalChicles, precioChicles) }
                    };

                    // Mostrar los totales de cada producto
                    foreach (var producto in productos)
                    {
                        if (producto.Value.cantidad > 0)
                        {
                            Console.WriteLine($"Son: ${producto.Value.cantidad} de {producto.Key}");
                        }
                    }

                    // Mostrar el total final
                    cuentaTotal = totalFrituras + totalRefresco + totalJugo + totalGalletas + totalChicles;
                    Console.WriteLine($"\nSu total es de: ${cuentaTotal}");


                    // Guardar ticket en TXT
                    StreamWriter sw = new StreamWriter(".\\docs\\ticket.txt");
                    sw.WriteLine("ABARROTES LEARN-CSHARP\n");
                    sw.WriteLine("Item  C  c/u  Total");

                    // Verificar total y escribir en ticket
                    foreach (var producto in productos)
                    {
                        if (producto.Value.cantidad > 0)
                        {
                            int cantidad = producto.Value.cantidad / producto.Value.precio;
                            sw.WriteLine($"{producto.Key} {cantidad} ${producto.Value.precio} ${producto.Value.cantidad}");
                        }
                    }
                    sw.WriteLine($"\nTOTAL COMPRA: ${cuentaTotal}");
                    sw.WriteLine("\nSignificado: \nItem= Nombre Producto. C= Cantidad. c/u= Precio Unitario.");
                    sw.Close();
                    Console.WriteLine("\nSe ha generado su ticket en un archivo llamado ticket.txt\n");

                    // Salir
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
