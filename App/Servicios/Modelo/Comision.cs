using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Comision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComision { get; set; }         // PK, Autogenerado, Incremental, Identidad
        public string? DescComision { get; set; }   // Nombre de la comisión - Ej: "1K01", "2Q01", ...
        public int NivelEspecialidad { get; set; }  // Año/Nivel de la carrera
        public int IdPlan { get; set; }             // FK al plan de estudio
    }
}
