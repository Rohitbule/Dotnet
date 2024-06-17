using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample array
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            // Reverse the array
            int[] reversedArray = ReverseArray(array);

            Console.WriteLine("Reversed array:");
            PrintArray(reversedArray);
            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] ReverseArray(int[] array)
        {
            int length = array.Length;
            int[] reversed = new int[length];

            for (int i = 0; i < length; i++)
            {
                reversed[i] = array[length - 1 - i];
            }

            return reversed;
        }
         

    }
}
