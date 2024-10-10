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
}