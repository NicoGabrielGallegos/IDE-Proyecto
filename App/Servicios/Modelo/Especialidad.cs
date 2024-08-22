using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Especialidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEspecialidad { get; set; }         // PK, Autogenerado, Incremental, Identidad
        public string? DescEspecialidad { get; set; }   // Título/Nombre de la especialidad
    }
}