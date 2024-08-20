using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Servicios.Context;
using Servicios.Modelo;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public UsuarioController(AcademiaContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Usuario")]
        public ActionResult<IEnumerable<Usuario>> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{DNI}")]
        public ActionResult<Usuario> GetByDNI(int DNI)
        {
            var usuario = _context.Usuarios.Find(DNI);
            if (usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }

        [HttpPost]
        public ActionResult<Usuario> Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetByDNI), new { DNI = usuario.DNI }, usuario);
        }

        [HttpPut("{DNI}")]
        public ActionResult<Usuario> Update(int DNI, Usuario usuario)
        {
            if (DNI != usuario.DNI)
            {
                return BadRequest();
            }
            _context.Entry(usuario).State = EntityState.Modified;
            return NoContent();
        }

        [HttpDelete("{DNI}")]
        public ActionResult<Usuario> Delete(int DNI)
        {
            var usuario = _context.Usuarios.Find(DNI);
            if (usuario == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return usuario;
        }
    }
}
