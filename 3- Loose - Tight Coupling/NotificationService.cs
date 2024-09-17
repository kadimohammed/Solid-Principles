using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Loose___Tight_Coupling
{
    internal class NotificationService
    {
        private INotificationService _notificationService;

        public NotificationService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Notify()
        {
            _notificationService.Send();
        }
    }
}
