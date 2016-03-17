using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTable
{
    class MultiplicationTable
    {
        public List<List<UInt64>> returnTable (List<UInt64> primes)
        {
            List<List<UInt64>> table = new List<List<UInt64>>();
            int index = 0;
            foreach (UInt64 p in primes)
            {
                table.Add(new List<UInt64>());
                foreach (UInt64 j in primes)
                {
                    table[index].Add(p*j);
                   
                }
                index++;
            }
            return table;

        }
    }
}
