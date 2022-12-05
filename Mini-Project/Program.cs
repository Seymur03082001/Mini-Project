using Mini_Project.Models;

namespace Mini_Project
{
    internal class Program
    {
        public static List<Music> AllMusic { get; set; }
        static void Main(string[] args)
        {
            Playlist<string> playlist = new Playlist<string>();
            playlist.Add();
            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine(playlist[i].ArtistName);
            }
            Console.WriteLine();
        }
    }
}