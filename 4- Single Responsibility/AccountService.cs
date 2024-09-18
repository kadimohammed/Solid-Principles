using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__Single_Responsibility
{
    internal class AccountService
    {
        public void Depot(Account account, decimal amount)
        {
            account.Balance += amount;
            EmailService emailService = new EmailService();
            emailService.SendEmail(account,$"votre dépôt de {amount} a été effectué avec succès.");
        }

        public void Retrait(Account account, decimal amount)
        {
            if (account.Balance - amount >= 0)
            {
                account.Balance -= amount;
                EmailService emailService = new EmailService();
                emailService.SendEmail(account, $"votre retrait de {-amount} a été effectué avec succès.");
            }
            else
            {
                Console.WriteLine($"Transaction échouée. Solde insuffisant pour retirer {-amount}. Solde actuel: {account.Balance}");
            }
        }
    }
}
