using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servicios.Modelo
{
    public class Dictado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDictado { get; set; }      // PK, Autogenerado, Incremental, Identidad
        public int LegajoDocente { get; set; }  // FK al legajo de un perfil de tipo "Docente"
        public int IdCurso { get; set; }        // FK al curso en el que dicta el docente
    }
}
