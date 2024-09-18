using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__Single_Responsibility
{
    internal class Account
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public Account(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        //sans respecter SRP
        /*public void Transaction(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Dépôt réussi de {amount}. Nouveau solde: {Balance}");
                Console.WriteLine($"Message envoyé: Cher {AccountHolder}, votre dépôt de {amount} a été effectué avec succès.");
            }
            else if (amount < 0)
            {
                if (Balance + amount >= 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Retrait réussi de {-amount}. Nouveau solde: {Balance}");
                    Console.WriteLine($"Message envoyé: Cher {AccountHolder}, votre retrait de {-amount} a été effectué avec succès.");
                }
                else
                {
                    Console.WriteLine($"Transaction échouée. Solde insuffisant pour retirer {-amount}. Solde actuel: {Balance}");
                    Console.WriteLine($"Message envoyé: Cher {AccountHolder}, votre tentative de retrait de {-amount} a échoué en raison d'un solde insuffisant.");
                }
            }
            else
            {
                Console.WriteLine("Montant invalide pour une transaction.");
            }
        }*/
    }
}
