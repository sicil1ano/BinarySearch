using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTwo_BinarySearch
{
    class Program
    {
        //As we know, the binary search algorithm requires a sorted array.
        static int[] mySortedArray = { 9, 74, 874, 2290, 43073, 279343 };

        /// <summary>
        /// Main program method.
        /// </summary>
        /// <param name="args">Arguments.</param>
        static void Main(string[] args)
        {
            var binarySearch = new BinarySearch();
            Console.WriteLine("We have the sorted array { 9, 74, 874, 2290, 43073, 279343 }");
            Console.WriteLine();
            Console.WriteLine("Iterative binary search starting..");
            Console.WriteLine();
            int elementToFind = 43073;
            int indexFound = binarySearch.ChopIterative(elementToFind, mySortedArray);
            Console.WriteLine(String.Format("The result of binary search for element {0} is the index {1} ",elementToFind,indexFound));
            if(indexFound != -1)
            {
                Console.WriteLine(String.Format("Indeed the array at index {0} has {1}",indexFound,mySortedArray[indexFound]));
            }
            Console.WriteLine();
            elementToFind = 9;
            indexFound = binarySearch.ChopIterative(elementToFind, mySortedArray);
            Console.WriteLine(String.Format("The result of binary search for element {0} is the index {1} ",elementToFind,indexFound));
            if(indexFound != -1)
            {
                Console.WriteLine(String.Format("Indeed the array at index {0} has {1}",indexFound,mySortedArray[indexFound]));
            }
            Console.WriteLine();
            elementToFind = 5;
            Console.WriteLine("Trying to search a not existing element : " + elementToFind + " What the result will be?");
            indexFound = binarySearch.ChopIterative(elementToFind, mySortedArray);
            Console.WriteLine(String.Format("The result of binary search for {0} (not existing element) is {1}",elementToFind,indexFound));
            Console.WriteLine();
            Console.WriteLine("Iterative binary search ended.");
            Console.WriteLine("---");
            Console.WriteLine();
            Console.WriteLine("Recursive binary search starting..");
            Console.WriteLine();
            elementToFind = 43073;
            indexFound = binarySearch.ChopRecursive(elementToFind, mySortedArray);
            Console.WriteLine(String.Format("The result of binary search for element {0} is the index {1} ", elementToFind, indexFound));
            if (indexFound != -1)
            {
                Console.WriteLine(String.Format("Indeed the array at index {0} has {1}", indexFound, mySortedArray[indexFound]));
            }
            Console.WriteLine();
            elementToFind = 9;
            indexFound = binarySearch.ChopRecursive(elementToFind, mySortedArray);
            Console.WriteLine(String.Format("The result of binary search for element {0} is the index {1} ", elementToFind, indexFound));
            if (indexFound != -1)
            {
                Console.WriteLine(String.Format("Indeed the array at index {0} has {1}", indexFound, mySortedArray[indexFound]));
            }
            Console.WriteLine();
            elementToFind = 789356;
            Console.WriteLine("Trying to search a not existing element : " + elementToFind + " What the result will be?");
            indexFound = binarySearch.ChopRecursive(elementToFind, mySortedArray);
            Console.WriteLine(String.Format("The result of binary search for {0} (not existing element) is {1}", elementToFind, indexFound));
            Console.WriteLine();
            Console.WriteLine("Recursive binary search ended.");
            Console.WriteLine("---");

            Console.ReadKey();

        }
    }
}
