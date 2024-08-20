using Microsoft.EntityFrameworkCore;
using Servicios.Modelo;

namespace Servicios.Context
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfiles {  get; set; }
        public DbSet<Especialidad> Especialidades {  get; set; }
        public DbSet<Plan> Planes {  get; set; }
        public DbSet<Materia> Materias {  get; set; }
        public DbSet<Correlatividad> Correlatividades {  get; set; }
        public DbSet<Curso> Cursos {  get; set; }
        public DbSet<Comision> Comisiones {  get; set; }
        public DbSet<Inscripcion> Inscripciones {  get; set; }
        public DbSet<Dictado> Dictados {  get; set; }
        public DbSet<MateriaPlan> MateriasPlanes {  get; set; }
    }
}
