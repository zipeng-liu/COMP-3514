using System;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService emailService = new EmailNotificationService();
            var emailSender = new NotificationSender(emailService);
            emailSender.SendNotification("E-mail message.");

            INotificationService smsService = new SmsNotificationService();
            var smsSender = new NotificationSender(smsService);
            smsSender.SendNotification("SMS message.");
        }
    }
}
