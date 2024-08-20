using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Inscripcion
    {
        [Key]
        public int IdInscripcion { get; set; }
        public int LegajoAlumno { get; set; }
        public int IdCurso { get; set; }
        public int? Condicion { get; set; } // null: Libre; 0: Regular; 1: Aprobada
        public int? Nota { get; set; }
    }
}
