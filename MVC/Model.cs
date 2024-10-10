public class Song
{
  public string Title { get; set; }
  public string Artist { get; set; }
  public string Album { get; set; }

  public Song(string title, string artist, string album)
  {
    Title = title;
    Artist = artist;
    Album = album;
  }
}

public class SongList
{
  List<Song> Songs = [];
  View view = new();

  public void AddSong(Song song)
  {
    Songs.Add(song);
  }

  public List<Song> GetSongs()
  {
    return Songs;
  }
  public void UpdateSongs(string newTitle, string newArtist, string newAlbum)
  {
    // Check if song is already registered
    Song? existingSong;
    for (int i = 0; i < GetSongs().Count; i++)
    {
      Song currentSong = GetSongs()[i];
      if (currentSong.Title == newTitle && currentSong.Artist == newArtist)
      {
        existingSong = currentSong;
        Console.WriteLine("Song is already added");
        break;
      }
    };

    // Add song to List
    Song newSong = new Song(newTitle, newArtist, newAlbum)
    {
      Title = newTitle,
      Artist = newArtist,
      Album = newAlbum
    };
    AddSong(newSong);
  }
  public void ShowSongs(List<Song> songList)
  {
    Console.WriteLine("Showing list of songs" + songList.Count);
    foreach (var item in songList)
    {
      view.Display(item);
    }
  }
}