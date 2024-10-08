public class View
{
  public void Display(SongList song)
  {
    Console.WriteLine("Displaying the song information");
    Console.WriteLine(song.ToString());
  }
  public void Message(string message)
  {
    Console.WriteLine(message);
  }

}