using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }         // PK, Autogenerado, Incremental, Identidad
        public string? DescEspecialidad { get; set; }   // Título/Nombre de la especialidad
    }
}