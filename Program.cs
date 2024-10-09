namespace MVC;

class Program
{
    static void Main(string[] args)
    {
        SongList song = new SongList();
        View view = new View();
        Controller controller = new Controller(song, view);
        controller.UpdateSong();
        controller.ShowSongs();
    }
}
