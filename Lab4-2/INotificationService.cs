using System;

namespace DependencyInjection
{
    public interface INotificationService
    {
        void Send(string message);
    }
}
