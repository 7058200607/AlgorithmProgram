using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public static class anagram
    {
        public static void AnagarmNumber() 
        {
            Console.WriteLine("Enter a string1 :");
            string str1 =Console.ReadLine();
            Console.WriteLine("Enter a string2 :");
            string strl2=Console.ReadLine();
            char[] char1 = str1.ToUpper().ToCharArray();
            char[] char2 =str1.ToUpper().ToCharArray();
            Array.Sort(char1, char2);
            string newstr1 =new string(char1);
            string newstr2 =new string(char2);
            if(newstr1 == newstr2) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Both string are anagram");
                Console.ResetColor();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Both string are anagram");
                Console.ResetColor();
            }
            
        }

    }
}
