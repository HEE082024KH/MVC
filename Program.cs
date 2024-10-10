namespace MVC;

class Program
{
    static void Main(string[] args)
    {
        SongList song = new SongList();
        View view = new View();
        Controller controller = new Controller(song, view);
        Song song1 = new Song("Schism", "Tool", "Schism");
        Song song2 = new Song("6", "7", "8");
        Song song3 = new Song("3", "4", "5");
        song.AddSong(song1);
        song.AddSong(song2);
        song.AddSong(song3);
        controller.Run();
    }
}
