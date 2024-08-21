using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Inscripcion
    {
        [Key]
        public int IdInscripcion { get; set; }  // PK, Autogenerado, Incremental, Identidad
        public int LegajoAlumno { get; set; }   // FK al legajo de un perfil de tipo "Alumno"
        public int IdCurso { get; set; }        // FK al curso al que se inscribe el alumno
        public int? Condicion { get; set; }     // Condición del alumno dentro del curso - null: Libre; 0: Regular; 1: Aprobada
        public int? Nota { get; set; }          // Nota del curso una vez ha sido aprobado, es null si el alumno tiene condición "Libre" o "Regular"
    }
}
