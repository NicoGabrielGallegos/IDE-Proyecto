using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class MateriaPlan
    {
        [Key]
        public int IdMateriaPlan { get; set; }
        public int IdMateria { get; set; }
        public int IdPlan { get; set; }
    }
}
