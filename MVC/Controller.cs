public class Controller
{
  private SongList _songList;
  private View _view;

  public Controller(SongList song, View view)
  {
    _songList = song;
    _view = view;
  }

  // Add song to list from user input
  public void InputSong()
  {
    // Input title, artist, genre
    _view.Message("Enter song title");
    string? newTitle = Console.ReadLine();
    if (newTitle == null)
    {
      Console.WriteLine("Invalid title");
      return;
    }
    _view.Message("Enter artist name");
    string? newArtist = Console.ReadLine();
    if (newArtist == null)
    {
      Console.WriteLine("Invalid artist");
      return;
    }
    _view.Message("Enter album name");
    string? newAlbum = Console.ReadLine();
    if (newAlbum == null)
    {
      Console.WriteLine("Invalid album");
      return;
    }

    _songList.UpdateSongs(newTitle, newArtist, newAlbum);
  }

  SongList song = new SongList();

  // Method to choose operation from user input.
  public void Run()
  {

    bool exit = false;

    while (!exit)
    {
      Console.WriteLine("Type u to update song, o to write list, e to exit");
      string? input = Console.ReadLine();
      switch (input)
      {
        case "u":
          InputSong();
          break;
        case "o":
          song.ShowSongs(song.GetSongs());
          break;
        case "e":
          exit = true;
          break;
      }
    }
  }
}