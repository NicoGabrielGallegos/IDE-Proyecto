using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Dictado
    {
        [Key]
        public int IdDictado { get; set; }      // PK, Autogenerado, Incremental, Identidad
        public int LegajoDocente { get; set; }  // FK al legajo de un perfil de tipo "Docente"
        public int IdCurso { get; set; }        // FK al curso en el que dicta el docente
    }
}
