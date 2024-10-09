public class Song
{
  public required string Title { get; set; }
  public required string Artist { get; set; }
  public required string Genre { get; set; }

  public Song(string title, string artist, string genre)
  {
    Title = title;
    Artist = artist;
    Genre = genre;
  }
}

public class SongList
{
  public List<Song> Songs { get; set; }

  public SongList()
  {
    Songs = new List<Song>
    {
      // new Song("Tool", "Schism", "Progressive Metal")
    };
  }
}