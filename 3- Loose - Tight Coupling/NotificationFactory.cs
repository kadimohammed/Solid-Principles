using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Loose___Tight_Coupling
{
    internal class NotificationFactory
    {
        public static INotificationService? Create(NotificationMode mode)
        {
            switch(mode)
            {
                case NotificationMode.Sms:
                    return new SmsService();
                case NotificationMode.Email: 
                    return new EmailService();
                default:
                    return null;
            }
        }
    }
}
