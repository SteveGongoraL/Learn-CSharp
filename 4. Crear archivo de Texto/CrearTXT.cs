using System;
using System.IO;

namespace CSharpGuardarTextos
{
    class CSharpGuardarTextos
    {
        static void Main(string[] args)
        {
            try
            {
                string rutaPath = ".\\docs\\miArchivo.txt";
                
                // Escribir en el TXT
                using (StreamWriter sw = new StreamWriter(rutaPath))
                {
                    sw.WriteLine("Bienvenido al archivo de texto");
                    sw.WriteLine("Aquí puedes almacenar texto fijo o dinámico usando variables");
                    sw.Close();
                }
                
                // Leer el contenido de un TXT
                using (TextReader tw = new StreamReader(rutaPath))
                {
                    Console.WriteLine(tw.ReadToEnd());
                    tw.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("El archivo se ha guardado y abrio con éxito");
            }
        }
    }
}