using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Correlatividad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCorrelatividad { get; set; }   // PK, Autogenerado, Incremental, Identidad
        public int IdMateriaInd { get; set; }       // FK a la materia que debe ser aprobada/regularizada para cursar/rendir la materia dependiente
        public int IdMateriaDep { get; set; }       // FK a la materia dependiente
        public int TipoCorrelatividad { get; set; } // Indica si la correlatividad es para cursar o para rendir - 0: Para cursar; 1: Para rendir
        public int TipoCondicion { get; set; }      // Indica la condición en la que se debe encontrar la materia independiente - 0: Regular; 1: Aprobada
    }
}
