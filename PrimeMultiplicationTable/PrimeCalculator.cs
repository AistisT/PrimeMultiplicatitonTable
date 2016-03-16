using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTable
{
    public class PrimeCalculator
    {
        public List<UInt64> returnPrimes(UInt64 n)
        {
            List<UInt64> primeList = new List<UInt64>() {2};  // first prime number
            UInt64 count = 1, nextPrime = 3; // increment ammount and next prime
            while ((UInt64)primeList.Count() < n)
            {
                int index = 0;
                while (primeList[index] <= Math.Sqrt(nextPrime) && (nextPrime % primeList[index] != 0)) // checking if next prime evenly divides with previous primes up to square root of next prime
                {
                    index++;
                }
                if (primeList[index] > Math.Sqrt(nextPrime) && count == 1) // checking if current prime is greater than square root of next prime
                {
                    primeList.Add(nextPrime);
                    count = 2;  
                    nextPrime = nextPrime + 2; // 2 is only even prime number, increment  by 2 after 3 to skip even numbers
                }

                else if (primeList[index] > Math.Sqrt(nextPrime) && count == 2)
                {
                    primeList.Add(nextPrime);
                    if (nextPrime ==5) // 3, 5, 7 are only case of triplets of prime numbers, this could be omited if min ammount of primes was 4 instead of 1, by using starting primes
                    {
                        count = 1;
                        nextPrime = nextPrime + 2;
                    }
                    else
                    {
                        count = 1;
                        nextPrime = nextPrime + 4; // skip 4 digits after encoutering twin primes
                    }
                }
                else
                {
                    count = 1;
                    nextPrime = nextPrime + 2;
                }
            }
            return primeList;
        }
    }
}
