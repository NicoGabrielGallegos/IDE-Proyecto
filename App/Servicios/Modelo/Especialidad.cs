using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }
        public string? DescEspecialidad { get; set; }
    }
}