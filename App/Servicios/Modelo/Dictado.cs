using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Dictado
    {
        [Key]
        public int IdDictado { get; set; }
        public int LegajoDocente { get; set; }
        public int IdCurso { get; set; }
    }
}
