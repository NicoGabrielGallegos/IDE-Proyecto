using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }
        public string? DescMateria { get; set; }
        public int TipoDictado {  get; set; } // 0: Anual; 1: 1er Cuatrimestre; 2: 2do Cuatrimestre; 3: 1er/2do Cuatrimestre
        public int HsSemanales { get; set; }
        public int HsTotales {  get; set; }
    }
}
