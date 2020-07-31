using System.Collections.Generic;
using Classfields.Business.Notifications;

namespace Classfields.Business.Interfaces
{
    public interface Inotificator
    {
        bool HaveNotifications();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}