using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArrays2
{
    class Program
    {
        // This method is receiving an array, calculating the sum, then using the sum to get the mean. 
        public static double SumOfArr(int[] sum)
        {
            double result = 0.0;

            for (int i = 0; i < sum.Length; i++)
            {
                result += sum[i];
            }

            return result / sum.Length;
            
        }
        // This method reverses any array of numbers.
        public static void GetRev(int[] input)
        {

            Console.Write("{");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                
                Console.Write(input[i] + " ");

            }
            Console.WriteLine("}");
            
            
            
        }
        // This method rotates arrays receiving whatever direction, "left" or "right", the amount of spaces to move, and the array to rotate. 
        public static void ReturnRotatedArray(string shift, int spaces, int[] input)
        {
            

            if (shift == "right")
            {
                for (int i = input.Length - spaces; i < input.Length; i++)
                {
                    Console.Write(input[i] + " ");
                }
                for (int i = 0; i < input.Length - spaces; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
            if (shift == "left")
            {
                for (int i = spaces; i < input.Length; i++)
                {
                    Console.Write(input[i] + " ");
                }
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
            Console.WriteLine();
        }
        // This method uses the bubble sort method to sort any number of arrays in numerical order.
        public static void GetSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
                
            }
            foreach (int i in input)
            {
                Console.Write(i + " ");
            }

        }

        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("The mean of array A is " + (SumOfArr(A)));            
            Console.WriteLine("The mean of array B is " + (SumOfArr(B)));
            Console.WriteLine("The mean of array C is " + (SumOfArr(C)));
            
            Console.Write("Array A reversed is: ");
            GetRev(A);
            Console.Write("Array B reversed is: ");
            GetRev(B);
            Console.Write("Array C reversed is: ");
            GetRev(C);

            Console.Write("Array A rotated is: ");
            ReturnRotatedArray("right", 2, A);
            Console.Write("Array B rotated is: ");
            ReturnRotatedArray("right", 2, B);
            Console.Write("Array C rotated is: ");
            ReturnRotatedArray("left", 4, C);
            Console.Write("Array C sorted using the bubble sort method is: ");
            GetSort(C);
            Console.ReadLine();
            
        }
    }
}
