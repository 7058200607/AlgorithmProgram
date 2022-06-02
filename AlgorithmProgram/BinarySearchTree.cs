using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BinarySearchTree
    {
        public static void Abinarysearchtree() 
        {
            // List creation
            List<string> Geek = new List<string>();

            // List elements
            Geek.Add("ABCD");
            Geek.Add("QRST");
            Geek.Add("XYZ");
            Geek.Add("IJKL");


            Console.WriteLine("The Original List is:");
            foreach (string g in Geek)
            {

                // prints original List
                Console.WriteLine(g);

            }

            Console.WriteLine("\nThe List in Sorted form");

            // sort the List
            Geek.Sort();


            Console.WriteLine();
            foreach (string g in Geek)
            {
                // prints the sorted List
                Console.WriteLine(g);

            }

            Console.WriteLine("\nInsert EFGH :");

            // insert "EFGH" in the List
            //"EFGH" insert into its original
            // position when the List is sorted
            int index = Geek.BinarySearch("EFGH");


            if (index < 0)
            {

                Geek.Insert(~index, "EFGH");
            }

            Console.WriteLine();

            foreach (string g in Geek)
            {

                // prints the sorted list
                // after inserting "EFGH"
                Console.WriteLine(g);
            }
        }
    }
}

