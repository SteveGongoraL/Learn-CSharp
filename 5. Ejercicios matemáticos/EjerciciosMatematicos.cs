using System;
using System.IO;

namespace CSharpEjerciciosMatematicos
{
    // Funcion para guardar información en un TXT
    public class GuardarEnTXT
    {
        public static string SaveTxt(string nombreArchivo, string tituloDelArchivo, string cuerpoDelArchivo)
        {
            StreamWriter sw = new StreamWriter($".\\docs\\{nombreArchivo}.txt");
            sw.WriteLine(tituloDelArchivo);
            sw.WriteLine(cuerpoDelArchivo);
            sw.Close();
            return "El resultado se guardo exitosamente en un archivo txt.";
        }
    }
    // Ejecución del programa
    class EjerciciosMatematicos
    {
        static void Main(string[] args)
        {
            // Declarando variables
            int opcionElegida;
            double valor1, valor2, areaCuadrado = 0, areaRectangulo = 0, areaCirculo = 0;
            bool continuar = true;

            // Bucle WHILE
            while(continuar){
                // Preguntar por la operación a realizar
                Console.WriteLine("\nBienvenido, ¿Qué operación desea realizar?:");
                Console.WriteLine("1)-División con residuo. 2)-Área de figuras. 3)-Raiz. 4)-Salir");
                opcionElegida = int.Parse(Console.ReadLine());

                // Condicional IF
                if(opcionElegida == 1)
                {
                    // Pedir valores
                    Console.WriteLine("\n¿Cual es el primer numero?: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("¿Cual es el segundo numero?: ");
                    valor2 = double.Parse(Console.ReadLine());
                    double residuoDeDivision = valor1 % valor2;
                    // Preparar los atributos para la función
                    string nombreArchivo = "Resultado del Residuo";
                    string cuerpoDelArchivo = $"\nEl residuo de dividir: {valor1} / {valor2} es: {residuoDeDivision}";
                    // Llamando a la función para guardar en TXT
                    string resultado = GuardarEnTXT.SaveTxt(nombreArchivo,nombreArchivo,cuerpoDelArchivo);
                    Console.WriteLine($"{cuerpoDelArchivo} \n{resultado}");
                }
                else if(opcionElegida == 2)
                {
                    // Preguntar por la operación a realizar
                    Console.WriteLine("\n¿De que figura desea saber el area?");
                    Console.WriteLine("1)-Cuadrado. 2)-Rectangulo. 3)-Circulo.");
                    opcionElegida = int.Parse(Console.ReadLine());
                    
                    // Evaluando la operación
                    if(opcionElegida == 1)
                    {
                        Console.WriteLine("¿Cual es el valor de la altura?");
                        valor1 = double.Parse(Console.ReadLine());
                        areaCuadrado =  Math.Pow(valor1, 2);
                        Console.WriteLine($"El area es:  {areaCuadrado}");
                    }
                    else if(opcionElegida == 2)
                    {
                        Console.WriteLine("¿Cual es el valor de la altura?");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("¿Cual es el valor de la base?");
                        valor2 = double.Parse(Console.ReadLine());
                        areaRectangulo = valor1 * valor2;
                        Console.WriteLine($"El area del Rectangulo es: {areaRectangulo}");
                    }
                    else if(opcionElegida == 3)
                    {
                        Console.WriteLine("¿Cual es el valor del radio?");
                        valor1 = double.Parse(Console.ReadLine());
                        areaCirculo = 3.14 * Math.Pow(valor1, 2);
                        Console.WriteLine($"El area del Circulo es: {areaCirculo}");
                    }
                    else
                    {
                        Console.WriteLine("Debes escoger una figura valida");
                    }

                    // Guardar en un TXT
                    StreamWriter sw = new StreamWriter(".\\docs\\Resultado de Areas.txt");
                    sw.WriteLine("Las areas obtenidas son las siguientes:");

                    if(areaCuadrado != 0)
                    {
                        sw.WriteLine($"\nEl area del cuadrado es: {areaCuadrado}");
                    }
                    if(areaRectangulo != 0)
                    {
                        sw.WriteLine($"El area del rectangulo es: {areaRectangulo}");
                    }
                    if(areaCirculo != 0)
                    {
                        sw.WriteLine($"El area del circulo es: {areaCirculo}");
                    }
                    sw.Close();
                    Console.WriteLine("\nLa información de las areas se ha guardado en un archivo txt");
                }
                else if(opcionElegida == 3)
                {
                    // Pedir valores
                    // Sacar la raiz cuadrada del numero
                    Console.WriteLine("¿Cual es el número del que deseas sacar la raiz?");
                    valor1 = double.Parse(Console.ReadLine());
                    double raiz = Math.Sqrt(valor1);
                    // Elevar a x potencia el resultado anterior.
                    Console.WriteLine("¿A que potencia deseas elevar la raiz anterior?");
                    valor2 = double.Parse(Console.ReadLine());
                    double resultado = Math.Pow(raiz, valor2);

                    // Preparar los atributos para la función
                    string nombreArchivo = "Resultado de la raiz-elevacion";
                    string cuerpoDelArchivo = $"\nLa raiz cuadrada de: {valor1} es: {raiz} \nElevado a la {valor2} potencia, da como resultado: {resultado}\n";
                    // Llamando a la función para guardar en TXT
                    string resultadoFuncion = GuardarEnTXT.SaveTxt(nombreArchivo,nombreArchivo,cuerpoDelArchivo);
                    Console.WriteLine($"{cuerpoDelArchivo} \n{resultadoFuncion}");
                }
                else if(opcionElegida == 4)
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
