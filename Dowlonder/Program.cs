using CliWrap;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace Dowlonder {
    class Program
    {
        static async Task Main(string[] args)
        {
            string videoUrl = "https://www.youtube.com/watch?v=PZIcR7VHi-U";
            
            var info = new GetInfo(videoUrl);
            var commandOne = new CommandOne(info);
            commandOne.Run();

            var file = new Dowland(videoUrl);
            var commandTwo = new CommandTwo(file);
            commandTwo.Run();
        }
    }
}