public class View
{
  public void Display(Song song)
  {
    Console.WriteLine(song.Title);
    Console.WriteLine(song.Artist);
    Console.WriteLine(song.Album);
  }
  public void Message(string message)
  {
    Console.WriteLine(message);
  }

  // Method to display the current songs in the list
  public void ShowSongs(List<Song> songList)
  {
    Console.WriteLine("Showing list of songs" + songList.Count);
    foreach (var item in songList)
    {
      Display(item);
    }
  }
}