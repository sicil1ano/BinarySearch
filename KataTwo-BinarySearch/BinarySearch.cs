using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTwo_BinarySearch
{
    public class BinarySearch
    {
        /// <summary>
        /// Iterative binary search. It uses the for loops to find the given element.
        /// </summary>
        /// <param name="elementToFind">The element we want to find.</param>
        /// <param name="inputArray">The array in which we want to find the given element.</param>
        /// <returns></returns>
        public int ChopIterative(int elementToFind, int[] inputArray)
        {
            int indexFound = -1;

            for (int i = 0; i < (inputArray.Length / 2); i++)
            {
                if (inputArray[i] == elementToFind)
                {
                    indexFound = i;
                    return indexFound;
                }
            }

            for (int i = (inputArray.Length / 2); i < (inputArray.Length - 1); i++)
            {
                if (inputArray[i] == elementToFind)
                {
                    indexFound = i;
                    return indexFound;
                }
            }

            return -1;
        }

        /// <summary>
        /// Recursive binary search. It checks, recursively, if the given element is in the left middle or right middle of given array.
        /// </summary>
        /// <param name="elementToFind">The element we want to find.</param>
        /// <param name="inputArray">The array in which we want to find the given element.</param>
        /// <returns></returns>
        public int ChopRecursive(int elementToFind, int[] inputArray)
        {
            return ChopRecursiveMain(elementToFind, inputArray, 0, inputArray.Length - 1);
        }

        /// <summary>
        /// Main recursive binary search algorithm.
        /// </summary>
        /// <param name="elementToFind">The element we want to find.</param>
        /// <param name="inputArray">The array in which we want to find the given element.</param>
        /// <param name="min">The minimum index of the given array for the search.</param>
        /// <param name="max">The maximum index of the given array for the search.</param>
        /// <returns></returns>
        private int ChopRecursiveMain(int elementToFind, int[] inputArray, int min, int max)
        {
            //When the recursive search has ended, without finding the element both in the left or in the right middle of the array, we have this condition.
            if (min > max)
            {
                return -1;
            }
            int indexMiddleElement = min + (max - min) / 2;

            if (elementToFind < inputArray[indexMiddleElement])
            {
                return ChopRecursiveMain(elementToFind, inputArray, 0, indexMiddleElement - 1);
            }
            else if (elementToFind > inputArray[indexMiddleElement])
            {
                return ChopRecursiveMain(elementToFind, inputArray, indexMiddleElement + 1, inputArray.Length - 1);
            }
            else
            {
                return indexMiddleElement;
            }
        }
    }
}
