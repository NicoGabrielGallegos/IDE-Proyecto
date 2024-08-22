using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Servicios.Context;
using Servicios.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public PerfilController(AcademiaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Perfil")]
        public ActionResult<IEnumerable<Perfil>> GetAll()
        {
            return _context.Perfiles.ToList();
        }

        [HttpGet("{IdPerfil}")]
        public ActionResult<Perfil> GetById(int IdPerfil)
        {
            var perfil = _context.Perfiles.Find(IdPerfil);
            if (perfil == null)
            {
                return NotFound();
            }
            return perfil;
        }

        [HttpGet("legajo/{Legajo}")]
        public ActionResult<Perfil> GetByLegajo(int Legajo)
        {
            var perfiles = _context.Perfiles
                            .Where(p => p.Legajo == Legajo)
                            .ToList();
            if (perfiles.Count() == 0)
            {
                return NotFound();
            }
            return perfiles[0];
        }

        [HttpGet("dni/{DNI}")]
        public ActionResult<IEnumerable<Perfil>> GetByUsuarioDNI(int DNI)
        {
            return _context.Perfiles
                    .Where(p => p.DNI == DNI)
                    .ToList();
        }

        [HttpGet("dataGridFormat/{DNI}")]
        public ActionResult<IEnumerable<object>> GetDataGridViewFormat(int DNI)
        {
            return _context.Perfiles
                    .Where(p => p.DNI == DNI)
                    .GroupJoin(_context.Especialidades, p => p.IdEspecialidad, e => e.IdEspecialidad,
                    (p, eList) => new {p, subgroup = eList.AsQueryable()})
                    .SelectMany(joinedSet => joinedSet.subgroup.DefaultIfEmpty(),
                    (joinedSet, e) => new { TipoPerfil = joinedSet.p.TipoPerfil == 0 ? "Alumno" : joinedSet.p.TipoPerfil == 1 ? "Docente" : "Administrador",
                                    Legajo = joinedSet.p.Legajo == null ? "-" : joinedSet.p.Legajo.ToString(),
                                    Especialidad = e == null ? "-" : e.DescEspecialidad,
                                    Estado = joinedSet.p.Activado == true ? "Habilitado" : "No habilitado" })
                    .ToList();
                /*
                    .Where(p => p.DNI == DNI)
                    .Join(_context.Especialidades, p => p.IdEspecialidad, e => e.IdEspecialidad,
                    (p, e) => new {
                        TipoPerfil = p.TipoPerfil == 0 ? "Alumno" : p.TipoPerfil == 1 ? "Docente" : "Administrador",
                        Legajo = p.Legajo == null ? "-" : p.Legajo.ToString(),
                        Especialidad = e == null ? "-" : e.DescEspecialidad,
                        Estado = p.Activado == true ? "Habilitado" : "No habilitado" })
                    .ToList();
                */
        }

        [HttpPost]
        public ActionResult<Perfil> Create(Perfil perfil)
        {
            _context.Perfiles.Add(perfil);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { IdPerfil = perfil.IdPerfil }, perfil);
        }

        [HttpPut("{IdPerfil}")]
        public ActionResult<Perfil> Update(int IdPerfil, Perfil perfil)
        {
            if (IdPerfil != perfil.IdPerfil)
            {
                return BadRequest();
            }
            _context.Entry(perfil).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{IdPerfil}")]
        public ActionResult<Perfil> Delete(int IdPerfil)
        {
            var perfil = _context.Perfiles.Find(IdPerfil);
            if (perfil == null)
            {
                return NotFound();
            }
            _context.Perfiles.Remove(perfil);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
