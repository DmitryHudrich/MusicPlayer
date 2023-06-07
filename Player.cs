using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Player
    {
        private readonly string _folderPath;
        private readonly string _files;

        public Player(string folderPath)
        {
            if (!string.IsNullOrEmpty(folderPath))
            {
                _folderPath = folderPath;


            }

        }
        public void Play()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(_folderPath);
            FileInfo[] files = dirInfo.GetFiles();

            foreach (FileInfo file in files)
            {
                using (var audioPlayer = new WaveOutEvent())
                {
                    // Загрузка аудиофайла
                    using (var audioFileReader = new AudioFileReader(file.FullName))
                    {
                        audioPlayer.Init(audioFileReader);

                        audioPlayer.Play();

                        Console.ReadKey();
                    }
                }
            }
        }
    }
}