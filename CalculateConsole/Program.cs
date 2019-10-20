using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fourPrimes = CalculateHelper.FindFourPrimes() ?? new int[] { };
            if (fourPrimes.Length > 0)
            {
                foreach (var prime in fourPrimes)
                {
                    Console.WriteLine(prime);
                }
            }



        }




  




    }
}
