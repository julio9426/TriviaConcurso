using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaConcurso.Entidades
{
   public class Jugador:BaseEntidad
    {
       public string Nombre { get; set; }
       public int Puntos { get; set; }
       public DateTime? FechaJuego { get; set; }
    }
}
