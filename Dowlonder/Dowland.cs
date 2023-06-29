using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using CliWrap;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Dowlonder
{
    internal class Dowland
    {
        YoutubeClient youtube = new YoutubeClient();
        string videoUrl;

        public Dowland(string _videoUrl)
        {
            videoUrl = _videoUrl;
        }

        public async Task DownloadAsync() 
        {
            var video = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}
