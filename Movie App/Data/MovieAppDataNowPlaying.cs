//namespace Movie_App.Data.MovieAppData; // Razor won't recognize third level namespace
namespace Movie_App.MovieAppData;

public class NowPlayingType
{
    public string? Name { get; set; }
    public string? Genre { get; set; }
    public string? Description { get; set; }
    public string? MoviePoster { get; set; }
}
