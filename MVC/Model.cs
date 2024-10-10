public class Song
{
  public required string Title { get; set; }
  public required string Artist { get; set; }
  public required string Album { get; set; }

  public Song(string title, string artist, string album)
  {
    Title = title;
    Artist = artist;
    Album = album;
  }
}

public class SongList
{
  public List<Song> Songs { get; set; }

  public SongList()
  {
    Songs = new List<Song>
    {
      // new Song("Schism", "Tool", "Lateralus")
      // new Song("Anesthetize", "Porcupine Tree", "Fear of a Blank Planet")
      // new Song("Lacquer Head", "Primus", "Antipop")
      // new Song("Hump De Bump", "Red Hot Chili Peppers", "Stadium Arcadium")
      // new song("Silver Tongue", "Alter Bridge", "Pawns & Kings")
    };
  }
}