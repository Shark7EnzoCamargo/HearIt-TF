using Hearit.DataAccess;
using Hearit.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Hearit.Dto.Request.BaseResponse;

namespace Hearit.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class VideoController : ControllerBase
    {
        private readonly HearitDbContext _context;

        public VideoController(HearitDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Video>>> Get()
        {
            ICollection<Video> response;

            response=await _context.Videos.ToListAsync();

            return Ok(response);
        }

        [HttpPost("Registro")]
        public async Task<ActionResult> Post(Dto.Request.DtoVideo request)
        {
            var entity = new Video
            {
                ArtistaId = request.ArtistaId,
                Titulo = request.Titulo,
                Descripcion = request.Descripcion,
                VideoURL = request.VideoURL,
            };

            _context.Videos.Add(entity);
            await _context.SaveChangesAsync();

            HttpContext.Response.Headers.Add("location", $"/api/video/{entity.Id}*");

            return Ok();
        }

        [HttpDelete("Eliminar Video/{id:int}")]
        public async Task<ActionResult<Video>> Delete(int id)
        {
            var entity = await _context.Videos.FindAsync(id);
            if (entity == null)
            {
                return NotFound("Video no encontrado");
            }
            else
            {
                _context.Videos.Remove(entity);
                _context.SaveChanges();
                return Ok();
            }

            return Ok(entity);
        }

    }
}
