namespace EventHandlerDemo
{
    public class LogService
    {
        public void VideoEncoderEventHandler(object sender, VideoEventArgs e)
        {
            Console.WriteLine("LogService: Logging video encoding.... " + e.VideoTag.Title + $". Encoding duration: {e.EncodingDuration} seconds");
        } 
    }
}
