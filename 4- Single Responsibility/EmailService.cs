using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _4__Single_Responsibility
{
    internal class EmailService
    {
         public void SendEmail(Account account, string Message)
         {
            Console.WriteLine($"Dépôt réussi Nouveau solde: {account.Balance}");
            Console.WriteLine($"Message envoyé: Cher {account.AccountHolder}, "+Message);
        }
    }
}
