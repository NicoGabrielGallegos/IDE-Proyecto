using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPlan { get; set; }             // PK, Autogenerado, Incremental, Identidad
        public string? DescPlan { get; set; }       // Nombre del plan, generalmente indicando el tipo de título, la carrera y el año de vigencia del plan
        public int IdEspecialidad {  get; set; }    // FK a la especialidad/carrera del plan.
    }
}
