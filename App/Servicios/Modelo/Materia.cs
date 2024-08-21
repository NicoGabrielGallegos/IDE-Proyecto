using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }          // PK, Autogenerado, Incremental, Identidad
        public string? DescMateria { get; set; }    // Nombre de la materia
        public int TipoDictado {  get; set; }       // Tipo de dictado de la materia - 0: Anual; 1: 1er Cuatrimestre; 2: 2do Cuatrimestre; 3: 1er/2do Cuatrimestre
        public int HsSemanales { get; set; }        // Horas de cursado de la materia en una semana
        public int HsTotales {  get; set; }         // Horas de cursado totales durante el año/cuatrimestre - "24 * HsSemanales" si es anual o "12 * HsSemanales si es cuatrimestral" 
    }
}
