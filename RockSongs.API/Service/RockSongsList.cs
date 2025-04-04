using Newtonsoft.Json;

namespace RockSongs.API.Service;

public class RockSongsList
{
    private Dictionary<int, RockSong> _list = new Dictionary<int, RockSong> ();
    private ILogger<RockSongsList> _logger;

    public RockSongsList(ILogger<RockSongsList> logger)
    {
        _logger = logger;
        List<RockSong> songs = new List<RockSong>();
        songs = JsonConvert.DeserializeObject<List<RockSong>>(File.ReadAllText("Files/songs.json"));
        int counter = 0;
        foreach (RockSong rockSong in songs)
        {
            counter++;
            rockSong.Id = counter;
            _list.Add(counter, rockSong);
        }
    }

    public RockSong RandomSong()
    {
        int rnd = (new Random()).Next(1,_list.Count);
        return _list[rnd];
    }
}
