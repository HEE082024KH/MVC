namespace MVC;

class Program
{
    static void Main(string[] args)
    {
        SongList song = new SongList();
        View view = new View();
        Controller controller = new Controller(song, view);
        controller.UpdateSong();

        // Console.WriteLine("Type u to create/update, type o to output");
        // string? input = Console.ReadLine();
        // switch (input)
        // {
        //     case u:
        //         controller.UpdateSong();
        //         break;
        //     case o:
        //     // Output list
        //     default:
        //         break;
        // }
    }
}
