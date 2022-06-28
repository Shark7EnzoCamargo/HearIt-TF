using Hearit.DataAccess;
using Hearit.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Hearit.Dto.Request.BaseResponse;

namespace Hearit.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Busqueda_CancionController : ControllerBase
    {
        private readonly HearitDbContext _context;

        public Busqueda_CancionController(HearitDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Busqueda_Cancion>>> Get()
        {
            ICollection<Busqueda_Cancion> response;

            response = await _context.Busqueda_Cancions.ToListAsync();

            return Ok(response);
        }

        [HttpPost("Registro")]
        public async Task<ActionResult> Post(Dto.Request.DtoBusqueda_Cancion request)
        {
            var entity = new Busqueda_Cancion
            {
                UsuarioId = request.UsuarioId,
                CancionId = request.CancionId
            };

            _context.Busqueda_Cancions.Add(entity);
            await _context.SaveChangesAsync();

            HttpContext.Response.Headers.Add("location", $"/api/busqueda_cancion/{entity.Id}*");

            return Ok();
        }

    }
}
