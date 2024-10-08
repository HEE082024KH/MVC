public class View
{
  public void Display(SongList model)
  {
    Console.WriteLine("Displaying the song information");
    Console.WriteLine(model.ToString());
  }
  public void Message(string message)
  {
    Console.WriteLine(message);
  }
}