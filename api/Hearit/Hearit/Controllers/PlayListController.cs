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
    public class PlayListController : ControllerBase
    {
        private readonly IPlayListService _playlistService;

        public PlayListController(IPlayListService playlistService)
        {
            this._playlistService = playlistService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayList>>> Get()
        {
            return await _playlistService.GetPlayLists();
        }

        [HttpGet("{id}", Name = "GetPlayList")]
        public async Task<ActionResult<PlayList>> Get(int id)
        {
            var playlist = await _playlistService.GetPlayList(id);

            if (playlist == null)
            {
                return NotFound();
            }
            return Ok(playlist);
        }

        [HttpPost]
        public async Task<ActionResult<PlayList>> Post(PlayList playlist)
        {
            await _playlistService.CreatePlayList(playlist);
            return CreatedAtRoute("GetPlayList", new { id = playlist.Id }, playlist);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var playlist = await _playlistService.GetPlayList(id);
            if (playlist == null)
            {
                return NotFound();
            }

            await _playlistService.DeletePlayList(playlist);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, PlayList playlist)
        {
            if (id != playlist.Id)
            {
                return BadRequest();
            }

            await _playlistService.UpdatePlayList(playlist);

            return NoContent();
        }



    }
}
