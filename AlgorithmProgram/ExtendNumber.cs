﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class ExtendNumber
    {
        public static void displayPrimePalindrome()
        {
            int count = 0;
            int remainder =0;
            int reverse=0;
            Console.WriteLine("Prime Number between 1 to 1000 that are anagram and palindrome \n\n");
            for (int num = 2; num < 1000; num++) 
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                    if (count == 0) 
                    {
                        int temp = num;
                        while (temp > 0)
                        {
                            remainder = temp % 10;
                            reverse = (reverse * 10) + remainder;
                            temp /= 10;
                        }
                        if(reverse == num)
                        {

                            Console.Write(" " + num);
                        }
                            reverse = 0;

                    }
                    count = 0;
                 
            }




        }

    }
}
