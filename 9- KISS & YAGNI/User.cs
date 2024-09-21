using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__KISS___YAGNI
{
    internal class User
    {
        // Exemple YAGNI(You Aren’t Gonna Need It)
        // had lprincipe kaygolek matzidch chi 7aja 7etta te7tajha par exmple dans ce moment maranich me7tage Adress bla manzido 7etta ne7taj nekhdem bih
        public string Name { get; set; }
        public string Email { get; set; }

        // Ajout inutile de méthodes pour les adresses avant qu'elles ne soient requises
        //public string Address { get; set; }

        /*
        public void UpdateAddress(string newAddress)
        {
            Address = newAddress;
        }

        public string GetFullAddress()
        {
            return "Full address: " + Address;
        }
        */
    }
}
