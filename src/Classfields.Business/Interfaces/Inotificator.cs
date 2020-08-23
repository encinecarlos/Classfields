using System.Collections.Generic;
using Classfields.Business.Notifications;

namespace Classfields.Business.Interfaces
{
    public interface INotificator
    {
        bool HaveNotifications();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}