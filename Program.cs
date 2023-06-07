using NAudio.Wave;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Write("Папка с музыкой: ");
            string musicPath = Console.ReadLine();

            Player player = new(musicPath);
            player.Play();
        }
    }
}