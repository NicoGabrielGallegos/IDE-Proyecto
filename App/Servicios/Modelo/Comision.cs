using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Comision
    {
        [Key]
        public int IdComision { get; set; }
        public string? DescComision { get; set; }
        public int AnioEspecialidad { get; set; }
        public int IdPlan { get; set; }
    }
}
