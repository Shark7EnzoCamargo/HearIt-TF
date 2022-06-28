using Hearit.DataAccess;
using Hearit.Entities;
using Hearit.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Hearit.Dto.Request.BaseResponse;

namespace Hearit.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ArtistaController : ControllerBase
    {
        private readonly IArtistaService _artistaService;

        public ArtistaController(IArtistaService artistaService)
        {
            this._artistaService = artistaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nuevo_Artista>>> Get()
        {
            return await _artistaService.GetArtistas();
        }

        [HttpGet("{id}", Name = "GetArtista")]
        public async Task<ActionResult<Nuevo_Artista>> Get(int id)
        {
            var artista = await _artistaService.GetArtista(id);

            if (artista == null)
            {
                return NotFound();
            }
            return Ok(artista);
        }

        [HttpPost]
        public async Task<ActionResult<Nuevo_Artista>> Post(Nuevo_Artista artista)
        {
            await _artistaService.CreateArtista(artista);
            return CreatedAtRoute("GetArtista", new { id = artista.Id }, artista);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var artista = await _artistaService.GetArtista(id);
            if (artista == null)
            {
                return NotFound();
            }

            await _artistaService.DeleteArtista(artista);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Nuevo_Artista artista)
        {
            if (id != artista.Id)
            {
                return BadRequest();
            }

            await _artistaService.UpdateArtista(artista);

            return NoContent();
        }



    }
}
