using System;
using System.IO;

namespace FFMPEG_Installer
{
    class Program
    {
        public static String FFMPEGPATH = "C://FFMPEG";
        static void Main(string[] args)
        {
            Console.Title = "FFMPEG Installer by Eleria and Erein v1.2";
            

            Console.WriteLine("+--------------------------------------------------------+");
            Console.WriteLine("|   FFMPEG Installer for NadekoBot by Eleria and Erein   |");
            Console.WriteLine("+--------------------------------------------------------+");
            Console.WriteLine("|                Do you want to install?                 |");
            Console.WriteLine("|     1) Yes                                 2) No       |");
            Console.WriteLine("| This will remove the Directory C:/ffmpeg if it exists  |");
            Console.WriteLine("+--------------------------------------------------------+");
            //Waiting for User Input:
            var input = Console.ReadLine().Trim();

            if(input == "Yes")
            {
                if(Directory.Exists(FFMPEGPATH))
                {
                    Console.WriteLine("C://ffmpeg exists already. Deleting...");
                    Directory.Delete(FFMPEGPATH, true);
                    Directory.CreateDirectory(FFMPEGPATH);
                }
                else
                {
                    Console.WriteLine("Creating C://FFMPEG...");
                    Directory.CreateDirectory(FFMPEGPATH);
                }
                //Checking for Dir's done. Installer Part:

                if (Environment.Is64BitOperatingSystem)
                {
                    Console.WriteLine("x64 Operating System detected.");
                    Console.WriteLine("Downloading FFMPEG, this could take some time (no need for Coffee tho)");
                    Downloader.x64Downloader();
                }
                else
                {
                    Console.WriteLine("x32 Operating System detected.");
                    Console.WriteLine("Downloading FFMPEG, this could take some time (no need for Coffee tho)");
                    Downloader.x32Downloader();
                }
                Console.WriteLine("Downloading done.");
                Console.WriteLine("Adding FFMPEG to User Path...");
                Environment.SetEnvironmentVariable("path", FFMPEGPATH, EnvironmentVariableTarget.User);
                Console.WriteLine("Installation finished successfully. Press any Key to exit");
                var i2 = Console.ReadLine().Trim();
                return;
            }
            else
            {
                Console.WriteLine("Installation aborted.");
                return;
            }
        }
    }
}
