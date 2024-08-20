using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public int IdMateria { get; set; }
        public int IdComision { get; set; }
        public int CicloLectivo { get; set; }
        public int Cupo { get; set; }
    }
}
