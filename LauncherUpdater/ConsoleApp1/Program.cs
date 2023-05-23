using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            repeat:

            Console.WriteLine("Do you want to update the launcher? [Y/N]");

            ConsoleKey key = Console.ReadKey().Key;


            switch (key) 
            {
                case ConsoleKey.Y:

                    Console.Clear();
                    Console.WriteLine("Installing...");

                    Directory.Delete(Directory.GetCurrentDirectory() + @"\" + "Launcher",true);

                    Uri uri = new Uri("https://www.dropbox.com/s/4o0vt3v44u8nw8y/Launcher.zip?dl=1");


                    WebClient webClient = new WebClient();
                    webClient.DownloadFileAsync(uri, Directory.GetCurrentDirectory() + @"\Launcher.zip");

                    webClient.DownloadFileCompleted += delegate { FinishDownload(); };

                    break;

                case ConsoleKey.N: break;

                default:
                    Console.Clear();
                    goto repeat;
            }

            Console.ReadKey();
        }

        static void FinishDownload() 
        {
            ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + @"\Launcher.zip", Directory.GetCurrentDirectory());
            File.Delete(Directory.GetCurrentDirectory() + @"\Launcher.zip");

            Console.Clear();
            Console.WriteLine("Done!");
        }
    }
}
