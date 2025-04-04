namespace RockSongs.API.Service;

public class RockSong
{
    public int Id { get; set; }
    public string? Song { get; set; }
    public string? Artist { get; set; }
    public string? CallSign { get; set; }
    public long Time { get; set; }
    public string? Unique_ID { get; set; }
    public string? Combined { get; set; }
    public string? First { get; set; }
}
