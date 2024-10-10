using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerDemo
{
    public class VideoEventArgs : EventArgs
    {
        public Video VideoTag { get; set; }
        public TimeSpan EncodingDuration { get; set; }
    }

    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Rasie that event

        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        public event VideoEncoderEventHandler VideoEncoded;

        // EventHandler
        // EventHandler<TEventArgs> 

        //public event EventHandler<VideoEventArgs> VideoEncoded;



        public void Encode(Video video) {

            Console.WriteLine("Encoding video.....");
            Thread.Sleep(3000);
            TimeSpan duration = TimeSpan.FromSeconds(3);

            OnVideoEncoded(video, duration);

        }

        protected virtual void OnVideoEncoded(Video video, TimeSpan time)
        {
            if(VideoEncoded != null) VideoEncoded(this, new VideoEventArgs() { VideoTag = video, EncodingDuration = time });
        }
    }
}
