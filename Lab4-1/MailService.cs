namespace EventHandlerDemo
{
    public class MailService
    {
        public void VideoEncoderEventHandler(object sender, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an Email.... " + e.VideoTag.Title + $". Encoding duration: {e.EncodingDuration} seconds");
        }
    }
}
