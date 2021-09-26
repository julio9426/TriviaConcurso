namespace TriviaConcurso.Entidades
{
   public class Categoria:BaseEntidad
    {
        public string Descripcion { get; set; }
        public Nivel RondaCategoria { get; set;}
        public int Premio { get; set; }
        public int ContadorPreguntas { get; set; }
    }
}
