using System;
using System.IO;
using System.Net;

namespace FFMPEG_Installer
{
    class Downloader
    {
        public static String x64Address = "http://eleria.de/ffmpeg64.exe";
        public static String x32Address = "http://eleria.de/ffmpeg32.exe";

        public static void x64Downloader()
        {
            WebClient Downloader = new WebClient();
            Downloader.DownloadFile(x64Address, "ffmpeg.exe");
            File.Move("ffmpeg.exe", "C://FFMPEG/ffmpeg.exe");
        }
        
        public static void x32Downloader()
        {
            WebClient Downloader = new WebClient();
            Downloader.DownloadFile(x32Address, "ffmpeg.exe");
            File.Move("ffmpeg.exe", "C://FFMPEG/ffmpeg.exe");
        }
    }
}
