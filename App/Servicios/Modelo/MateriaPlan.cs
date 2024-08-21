using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class MateriaPlan
    {
        [Key]
        public int IdMateriaPlan { get; set; }  // PK, Autogenerado, Incremental, Identidad
        public int IdMateria { get; set; }      // FK a la materia que pertenece al plan
        public int IdPlan { get; set; }         // FK a un plan de estudio
        public bool Electiva {  get; set; }     // Indica si la materia es electiva dentro de dicho plan - 0: Obligatoria; 1: Electiva
    }
}
