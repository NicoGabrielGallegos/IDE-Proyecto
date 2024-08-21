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
            var perfiles = _context.Perfiles
                            .Where(p => p.DNI == DNI)
                            .ToList();
            if (perfiles.Count() == 0)
            {
                return NotFound();
            }
            return perfiles;
        }

        [HttpPost]
        public ActionResult<Boolean> Create(Perfil perfil)
        {
            _context.Perfiles.Add(perfil);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { IdPerfil = perfil.IdPerfil }, perfil);
        }

        [HttpPut("{IdPerfil}")]
        public ActionResult<Boolean> Update(int IdPerfil, Perfil perfil)
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
        public ActionResult<Boolean> Delete(int IdPerfil)
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
