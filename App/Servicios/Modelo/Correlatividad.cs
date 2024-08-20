using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Correlatividad
    {
        [Key]
        public int IdCorrelatividad { get; set; }
        public int IdMateriaInd { get; set; }
        public int IdMateriaDep { get; set; }
        public int TipoCorrelatividad { get; set; } // 0: Para cursar; 1: Para rendir
        public int TipoCondicion { get; set; } // 0: Regular; 1: Aprobada
    }
}
