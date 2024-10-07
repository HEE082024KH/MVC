public class Song
{
  public string? Title { get; set; }
  public string? Artist { get; set; }
  public string? Genre { get; set; }
}

public class Model
{
  public List<Song>? Songs { get; set; }

  public Model()
  {
    Songs = new List<Song>
    {
      //
    };
  }
}