using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Usuario
    {
        [Key]
        public int DNI { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Direccion { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string? Clave { get; set; }
    }
}
