using System;

namespace _5_Array
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Singel Deminsional Array");
            SingleDArray();
            Console.WriteLine();

            Console.WriteLine("Two Deminsinal Array");
            TwoDArray();

        }

        static void SingleDArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write("{0}",arr[i]);
            }
                Console.WriteLine();

            foreach(int i in arr)
            {
                Console.Write("{0}", i);
            }
        }

        static void TwoDArray()
        {
            int[,] arr2 = 
            {
                { 1, 2, 3 },
                { 4, 5, 6 } 
            };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {

                    Console.Write("{0} ", arr2[i,j]);
                }

            }
            Console.WriteLine();
                foreach (int i in arr2)
                {
                    Console.Write("{0}", i);
                }
        }
    }
}
