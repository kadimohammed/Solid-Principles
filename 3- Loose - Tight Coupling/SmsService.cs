using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Loose___Tight_Coupling
{
    internal class SmsService : INotificationService
    {
        public void Send()
        {
            Console.WriteLine("SMS sent");
        }
    }
}
