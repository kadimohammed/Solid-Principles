using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__KISS___YAGNI
{
    internal class Calculator
    {
        // Exemple KISS(Keep It Simple, Stupid)

        public int CalculateSum(int a, int b)
        {
            // Utilisation d'une structure complexe sans raison
            int result = a + b;
            return result;
        }

        public int CalculateSumV1(int a, int b)
        {
            return a + b;  // Code simple et direct
        }
    }
}
