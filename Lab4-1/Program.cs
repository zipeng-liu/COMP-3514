namespace EventHandlerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService();
             var logService = new LogService();

            videoEncoder.VideoEncoded += mailService.VideoEncoderEventHandler;
            videoEncoder.VideoEncoded += messageService.VideoEncoderEventHandler;
            videoEncoder.VideoEncoded += logService.VideoEncoderEventHandler;

            videoEncoder.Encode(video);
        }
    }
}
