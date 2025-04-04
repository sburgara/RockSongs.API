using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RockSongs.API.Service;

namespace RockSongs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RockSongsController : ControllerBase
    {
        private RockSongsList _rockSongsList;
        private ILogger<RockSongsController> _logger;

        public RockSongsController(ILogger<RockSongsController> logger, RockSongsList rockSongsList)
        {
            _logger = logger;
            _rockSongsList = rockSongsList;
        }

        [HttpGet("GetRandomSong")]
        public IActionResult GetRandomSong()
        {
            return Ok(_rockSongsList.RandomSong());
        }
    }
}
