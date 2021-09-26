using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace TriviaConcurso.Procesos
{
    public static class GuardaArchivos<T>
    {
        public static List<T> GuardaArchivo(string nombreArchivo, List<T> informacion) 
        {
            string informacionJson = JsonSerializer.Serialize(informacion);
            File.WriteAllText(nombreArchivo, informacionJson);
            return CargaArchivos<T>.CargaArchivoJson(nombreArchivo);
        }
    }
}
