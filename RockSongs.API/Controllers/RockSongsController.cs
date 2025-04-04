using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            _logger.LogTrace("Trace");
            _logger.LogDebug("Debug");
            _logger.LogInformation("Information");
            _logger.LogWarning("Warning");
            _logger.LogError("Error");
            _logger.LogCritical("Critical");
            RockSong rockSong = _rockSongsList.RandomSong();
            _logger.LogInformation(JsonConvert.SerializeObject(rockSong));
            return Ok(rockSong);
        }
    }
}
