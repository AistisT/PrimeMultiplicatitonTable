using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTable
{
    class Output
    {
        static void Main(string[] args)
        {
            PrimeCalculator calc = new PrimeCalculator();
            List<UInt64> primes = calc.returnPrimes(20);
            System.Diagnostics.Debug.WriteLine(primes.ToString());
            for (int i =0; i<primes.Count(); i++)
            {
                Console.WriteLine(primes[i]);
            }

            Console.ReadKey();
        }
    }
}
