public class Song
{
  public required string Title { get; set; }
  public required string Artist { get; set; }
  public required string Genre { get; set; }
}

public class SongList
{
  public List<Song> Songs { get; set; }

  public SongList()
  {
    Songs = new List<Song>
    {

    };
  }
}