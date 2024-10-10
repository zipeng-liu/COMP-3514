using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerDemo
{
    public class MessageService
    {
        public void VideoEncoderEventHandler(object sender, VideoEventArgs e)
        {
            Console.WriteLine("Message service, sending text.... " + e.VideoTag.Title + $". Encoding duration: {e.EncodingDuration} seconds");
        }
    }
}
