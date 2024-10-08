namespace MVC;

class Program
{
    static void Main(string[] args)
    {
        Controller controller = new Controller();

        SongList song = new SongList();
        View view = new View();
        Console.WriteLine("Type u to create/update, type o to output");
        string? input = Console.ReadLine();
        switch (input)
        {
            case u:
                controller.UpdateSong();
                break;
            case o:
            // Output list
            default:
                break;
        }
    }
}
