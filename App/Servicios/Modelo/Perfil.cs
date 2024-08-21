using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Perfil
    {
        [Key]
        public int IdPerfil { get; set; }   // PK, Autogenerado, Incremental, Identidad
        public int DNI { get; set; }        // FK a un usuario
        public int TipoPerfil { get; set; } // Indica el tipo de perfil - 0: Alumno; 1: Docente; 2: Administrador
        public int? Legajo { get; set; }    // Legajo del usuario, es null si el usuarios es de tipo "Administrador"
        public bool Activado { get; set; }  // Indica si el perfil está habilitado por un administrador
    }
}
