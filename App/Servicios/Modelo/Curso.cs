using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }        // PK, Autogenerado, Incremental, Identidad
        public int IdMateria { get; set; }      // FK a la materia que se cursa
        public int IdComision { get; set; }     // FK a la comisión en la que se cursa
        public int CicloLectivo { get; set; }   // Año del cursado
        public int Cupo { get; set; }           // Cantidad de alumnos permitidos
    }
}
