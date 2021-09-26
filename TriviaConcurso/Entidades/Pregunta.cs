using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaConcurso.Entidades
{
    public class Pregunta:BaseEntidad
    {
        public int IdentificadorCategoria { get; set; }
        public string TextoPregunta { get; set; }
        public int ContadorRespuestas { get; set; }
    }
}
