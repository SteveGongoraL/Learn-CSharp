using System;
using System.Collections.Generic;

namespace CSharpValidaciones
{
    class ValidarNombres
    {
        public static List<string> validarNombres(List<string> Recolectar_lstNombresPorValidar)
        {
            // Declarando las listas vacias
            List<string> lstMensajeDeRespuesta = new List<string>();
            List<int> lstContadorErrores = new List<int>();
            int contador = 1;

            // Validando los datos de la lista recibida de "RecolectarNombres.cs"
            foreach(string nombresPorValidar in Recolectar_lstNombresPorValidar)
            {
                for(int x = 0; x <= nombresPorValidar.Length - 1; x ++)
                {
                    if(char.IsDigit(Convert.ToChar(nombresPorValidar.Substring(x, 1))))
                    {
                        lstContadorErrores.Add(contador);
                        break;
                    }
                }
                contador += 1;
            }

            // Guardar el mensaje dependiendo donde este el error
            if(lstContadorErrores.Count > 0)
            {
                foreach(int contarErrores in lstContadorErrores)
                {
                    if(contarErrores == 1)
                    {
                        lstMensajeDeRespuesta.Add("Se encontro un error en el nombre");
                    }
                    else if(contarErrores == 2)
                    {
                        lstMensajeDeRespuesta.Add("Se encontro un error en el apellido paterno");
                    }
                    else if(contarErrores == 3)
                    {
                        lstMensajeDeRespuesta.Add("Se encontro un error en el apellido materno");
                    }
                }
            }

            // Retornar la respuesta
            return lstMensajeDeRespuesta;
        }
    }
}
