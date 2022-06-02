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
            Console.WriteLine("3.permutations of a String using iterative method and Recursion method.");
            Console.WriteLine("4.Insertion sort ");
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
                case 3:
                    String s;
                    String answer = "";

                    Console.Write("Enter the string : ");
                    s = Console.ReadLine();

                    Console.Write("\nAll possible strings are : ");
                    
                        permutationsOfString.permute(s, answer);
                    break;
                case 4:
                    int[] arr = { 12, 11, 13, 5, 6 };
                    InsertionSort ob = new InsertionSort();
                    ob.sort(arr);
                    InsertionSort.printArray(arr);
                    break;
                        
           
               

            }


        }

    }
}

