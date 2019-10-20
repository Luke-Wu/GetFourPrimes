using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateConsole
{
    public static class CalculateHelper
    {


        /// <summary>
        /// Get four prime numbers
        /// </summary>
        /// <returns>four prime numbers int array</returns>
        public static int[] FindFourPrimes()
        {
            var allPrimes = GetAllPrimes();

            for (var i = 0; i < allPrimes.Count(); i++)
            {
                for (var j = i + 1; j < allPrimes.Count(); j++)
                {
                    for (var k = j + 1; k < allPrimes.Count(); k++)
                    {
                        for (var l = k + 1; l < allPrimes.Count(); l++)
                        {
                            if (IsSeqLong((long)allPrimes[i] * allPrimes[j] * allPrimes[k] * allPrimes[l]))
                            {
                                return new int[] { allPrimes[i], allPrimes[j], allPrimes[k], allPrimes[l] };
                            }
                        }
                    }
                }
            }

            return null;
        }






        /// <summary>
        /// Get all the primes under 1000
        /// </summary>
        /// <returns></returns>
        private static List<int> GetAllPrimes()
        {

            var lstPrimes = new List<int>();
            for (var i = 2; i < 1000; i++)
            {
                if (IsPrime(i))
                {
                    lstPrimes.Add(i);
                }
            }

            return lstPrimes;

        }


        /// <summary>
        /// judge whether the number match the criterion
        /// </summary>
        /// <param name="lNum">The long number need to be judeged</param>
        /// <returns></returns>
        private static bool IsSeqLong(long lNum)
        {
            var strNum = lNum.ToString().Trim();
            if (strNum.Length != 12) return false;

            for (var i = 0; i < strNum.Length - 1; i++)
            {
                if (strNum[i] != strNum[i + 1] && (strNum[i+1] - strNum[i]) != 1)
                {
                    return false;
                }
            }

            return true;
        }




        /// <summary>
        /// judge whether num is a prime
        /// </summary>
        /// <param name="num">the number need to be judged</param>
        /// <returns></returns>
        private static bool IsPrime(int num)
        {
            if (num <= 3)
            {
                return num > 1;
            }

            if (num % 6 != 1 && num % 6 != 5)
            {
                return false;
            }
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 5; i <= sqrt; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;

        }








    }
}
