using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Usuario
    {
        [Key]
        public int DNI { get; set; }                    // PK, Autogenerado, Incremental, Identidad
        public string? Nombre { get; set; }             // Nombre del usuario
        public string? Apellido { get; set; }           // Apellido del usuario
        public string? Email { get; set; }              // Email del usuario
        public string? Direccion { get; set; }          // Dirección del usuario
        public DateOnly FechaNacimiento { get; set; }   // Fecha de nacimiento del usuario
        public string? Clave { get; set; }              // Contraseña del usuario
    }
}
