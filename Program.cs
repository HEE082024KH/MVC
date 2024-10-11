namespace MVC;

class Program
{
    static void Main(string[] args)
    {
        SongList song = new SongList();
        View view = new View();
        Controller controller = new Controller(song, view);
        Song song1 = new Song("Schism", "Tool", "Schism");
        Song song2 = new Song("Lacquer Head", "Primus", "Antipop");
        Song song3 = new Song("Hump De Bump", "Red Hot Chili Peppers", "Stadium Arcadium");
        song.AddSong(song1);
        song.AddSong(song2);
        song.AddSong(song3);
        controller.Run();
    }
}
