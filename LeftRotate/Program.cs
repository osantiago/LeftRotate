using System;

namespace LeftRotate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int d = 4; // number of rotations
            //int temp = 0;
            int[] b = new int[d]; // array of size of number of rotations

            // brute force O(n^2)
            //
            // loop through number of rotations d
            // for (int i = 0; i < d; i++)
            // {
            //     // store first item in array
            //     temp = a[0];
            //     // loop through array
            //     for (int j = 0; j < a.Length - 1; j++)
            //     {
            //         // current position gets next value
            //         a[j] = a[j+1];
            //         Console.Write(a[j] + " ");
            //     }
            //     Console.WriteLine();
            //     // put temp value at the end of the array
            //     a[a.Length - 1] = temp;
            // }

            // loop through array
            for (int i = 0; i < a.Length ; i++)
            {
                // place first d elements in b
                if (i < d)
                {
                    b[i] = a[i];
                }
                if (i < a.Length - d)
                {
                    // set current position value to value at current position + d
                    a[i] = a[i+d];
                    //Console.Write(a[i] + " ");
                }
                else
                {
                    // add be to end of array
                    a[i] = b[i - (a.Length - d)];
                    //Console.Write(a[i] + " ");
                }
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
