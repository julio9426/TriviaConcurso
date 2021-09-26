using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaConcurso.Entidades
{
    public class Respuesta:BaseEntidad
    {
        public int IdentificadorPregunta { get; set; }
        public string TextoRespuesta { get; set; }
        public bool Correcta { get; set; }
    }
}
