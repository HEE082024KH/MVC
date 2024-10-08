public class Controller
{
  private SongList _songs;
  private View _view;

  public Controller(SongList model, View view)
  {
    _songs = model;
    _view = view;
  }

  public void UpdateSong()
  {
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

    Song? song;

    for (int i = 0; i < _songs.Songs.Count; i++)
    {
      Song currentSong = _songs.Songs[i];
      if (currentSong.Title == newTitle && currentSong.Artist == newArtist)
      {
        song = currentSong;
        break;
      }
    };
  }
}