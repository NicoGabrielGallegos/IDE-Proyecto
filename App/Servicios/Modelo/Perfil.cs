using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Perfil
    {
        [Key]
        public int IdPerfil { get; set; }
        //[ForeignKey(nameof(Usuario.DNI))]
        public int DNI { get; set; }
        public int TipoPerfil { get; set; } // 0: Alumno; 1: Docente; 2: Administrador
        public int? Legajo { get; set; } // Usuarios del tipo Administrador tendrán este campo vacío
        public bool Activado { get; set; }
    }
}
