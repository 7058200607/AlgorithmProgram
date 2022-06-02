using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PrimeNumber
    {
        public static void APrime() 
        {

            int count = 0;
            Console.WriteLine("Prime Numbers between 1 to 1000 : ");
            for (int num = 2; num <= 1000; num++)
            {
                for (int i = 2; i <= num / 2; i++)
                {

                    if ( num % i == 0)
                    {
                        count++;
                    }

                }
                if (count == 0)
                {
                    Console.Write(num + " ");
                }
                count = 0;
            }
            Console.ReadKey();
        }
    }
}
