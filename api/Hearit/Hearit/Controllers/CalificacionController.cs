using Hearit.DataAccess;
using Hearit.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Hearit.Dto.Request.BaseResponse;

namespace Hearit.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CalificacionController : ControllerBase
    {
        private readonly HearitDbContext _context;

        public CalificacionController(HearitDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Calificacion>>> Get()
        {
            ICollection<Calificacion> response;

            response = await _context.Calificacions.ToListAsync();

            return Ok(response);
        }

        [HttpPost("Registro")]
        public async Task<ActionResult> Post(Dto.Request.DtoCalificacion request)
        {
            var entity = new Calificacion
            {
                UsuarioId = request.UsuarioId,
                ArtistaId = request.ArtistaId,
                Puntuacion = request.Puntuacion,
                Comentario = request.Comentario
            };

            _context.Calificacions.Add(entity);
            await _context.SaveChangesAsync();

            HttpContext.Response.Headers.Add("location", $"/api/calificacion/{entity.Id}*");

            return Ok();
        }

    }
}
