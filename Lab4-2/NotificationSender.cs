using System;

namespace DependencyInjection
{
    public class NotificationSender
    {
        private INotificationService _notificationService;

        public NotificationSender(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void SendNotification(string message)
        {
            _notificationService.Send(message);
        }
    }
}
