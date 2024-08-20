using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Plan
    {
        [Key]
        public int IdPlan { get; set; }
        public string? DescPlan { get; set; }
        public int IdEspecialidad {  get; set; }
    }
}
