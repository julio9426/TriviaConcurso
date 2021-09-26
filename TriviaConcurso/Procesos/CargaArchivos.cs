using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace TriviaConcurso.Procesos
{
   public static class CargaArchivos<T>
    {
        public static List<T> CargaArchivoJson(string nombreArchivo) 
        {
            string informacionJson=File.ReadAllText(nombreArchivo);
            var resultado = new List<T>();
            try
            {
                resultado = JsonSerializer.Deserialize<List<T>>(informacionJson);
            }
            catch (Exception error) 
            {
                Console.WriteLine(error.ToString());
            }
            return resultado;
        }
    }
}
