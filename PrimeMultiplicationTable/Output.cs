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
            Output output = new Output();
            while (true){
                    List<UInt64> primes = calc.returnPrimes(output.inputHelper());
                    for (int i = 0; i < primes.Count(); i++)
                    {
                        Console.WriteLine(primes[i]);
                    }
                }
            }


        private UInt64 inputHelper()
        {
            string inputvalue="";
            UInt64 n=0;
            while (!(UInt64.TryParse(inputvalue, out n) && n>=1)){
                Console.WriteLine("Input whole number greater than 1");
                inputvalue = Console.ReadLine();
            }
            return n;
        }
    }
}
