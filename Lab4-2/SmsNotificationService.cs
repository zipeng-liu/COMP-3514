using System;

namespace DependencyInjection
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
