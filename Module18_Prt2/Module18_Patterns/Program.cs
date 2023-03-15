using System.Reflection;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18_Prt2
{
    internal class Program
    {
        static async Task Main()
        {
            
            var sender = new Sender();
            
            var videoPlayer = new VideoPlayer();
           
            Console.WriteLine("Enter video Url:");
            videoPlayer.videoUrl = Console.ReadLine();

            var getVideoInfoCommand = new GetVideoInfoCommand(videoPlayer);
            var downloadVideoCommand = new DownloadVideoCommand(videoPlayer);
           
            sender.SetCommand(getVideoInfoCommand);
            
            await sender.Run();
            
            sender.SetCommand(downloadVideoCommand);
           
            await sender.Run();
            
        }
    }
}