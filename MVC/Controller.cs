public class Controller
{
  private SongList _songs;
  private View _view;

  public Controller(SongList song, View view)
  {
    _songs = song;
    _view = view;
  }

  public void UpdateSong()
  {
    // Input title, artist, genre
    _view.Message("Enter song title");
    string? newTitle = Console.ReadLine();
    if (newTitle == null)
    {
      return;
    }
    _view.Message("Enter artist name");
    string? newArtist = Console.ReadLine();
    if (newArtist == null)
    {
      return;
    }
    _view.Message("Enter genre name");
    string? newGenre = Console.ReadLine();
    if (newGenre == null)
    {
      return;
    }

    // Check if song is already registered
    Song? existingSong;

    for (int i = 0; i < _songs.Songs.Count; i++)
    {
      Song currentSong = _songs.Songs[i];
      if (currentSong.Title == newTitle && currentSong.Artist == newArtist)
      {
        existingSong = currentSong;
        break;
      }
    };

    // Add song to List
    Song newSong = new Song(newTitle, newArtist, newGenre)
    {
      Title = newTitle,
      Artist = newArtist,
      Genre = newGenre
    };
    _songs.Songs.Add(newSong);
  }

  public void ShowSongs()
  {
    _view.Display(_songs);
  }

  // public void Run();
  // Console.WriteLine("Type u to create/update, type o to output");
  // string? input = Console.ReadLine();
  // switch (input)
  // {
  //     case u:
  //         controller.UpdateSong();
  //         break;
  //     case o:
  //     // Output list
  //     default:
  //         break;
  // }
}