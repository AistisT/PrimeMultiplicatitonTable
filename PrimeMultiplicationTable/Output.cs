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
            PrimeGenerator prime = new PrimeGenerator();
            MultiplicationTable calc = new MultiplicationTable();
            Output output = new Output();
            while (true)
            {
                List<UInt64> primes = prime.returnPrimes(output.inputHelper());
                List<List<UInt64>> multTable = calc.returnTable(primes);
                Console.Write("{0,0}{1,7}","|", "|");
                foreach (int p in primes) {

                    Console.Write("{0,5}{1,2}", p, "|");
                }
                Console.WriteLine();
                for (int i = 0; i < multTable.Count(); i++)
                {
                    Console.Write("{0,0}{1,5}{2,2}","|", primes[i], "|");
                    for (int j = 0; j < multTable.Count(); j++)
                    {
                        Console.Write("{0,5}{1,2}", multTable[i][j],"|");
                    }
                    Console.WriteLine();
                }
            }
        }


        private UInt64 inputHelper()
        {
            string inputvalue = "";
            UInt64 n = 0;
            while (!(UInt64.TryParse(inputvalue, out n) && n >= 1))
            {
                Console.WriteLine("Input whole number greater than 1");
                inputvalue = Console.ReadLine();
            }
            return n;
        }
    }
}
