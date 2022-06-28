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
    public class CancionController : ControllerBase
    {
        private readonly ICancionService _cancionService;

        public CancionController(ICancionService cancionService)
        {
            this._cancionService = cancionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cancion>>> Get()
        {
            return await _cancionService.GetCancions();
        }

        [HttpGet("{id}", Name = "GetCancion")]
        public async Task<ActionResult<Cancion>> Get(int id)
        {
            var cancion = await _cancionService.GetCancion(id);

            if (cancion == null)
            {
                return NotFound();
            }
            return Ok(cancion);
        }

        [HttpPost]
        public async Task<ActionResult<Cancion>> Post(Cancion cancion)
        {
            await _cancionService.CreateCancion(cancion);
            return CreatedAtRoute("GetCancion", new { id = cancion.Id }, cancion);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var cancion = await _cancionService.GetCancion(id);
            if (cancion == null)
            {
                return NotFound();
            }

            await _cancionService.DeleteCancion(cancion);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Cancion cancion)
        {
            if (id != cancion.Id)
            {
                return BadRequest();
            }

            await _cancionService.UpdateCancion(cancion);

            return NoContent();
        }



    }
}
