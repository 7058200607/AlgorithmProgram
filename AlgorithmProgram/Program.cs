using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("0.Enter a prime Number :");
            Console.WriteLine("1.Program for anagram :");
            Console.WriteLine("2.Extend Program that anagram and palindrome");
            Console.WriteLine("Enter a choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    PrimeNumber.APrime();
                    break;
                case 1:
                    anagram.AnagarmNumber();
                    break;
                case 2:
                    ExtendNumber.displayPrimePalindrome();
                    break;
                        
           
                    

            }


        }

    }
}

