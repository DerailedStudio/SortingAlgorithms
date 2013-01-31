using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        public static int[] selectionSort(int[] a)
        {
            int[] b = new int[a.Length];
            a.CopyTo(b, 0);

            for (int i = 0; i < b.Length; i++)
            {

                int minIndex = i;

                for (int j = i; j < b.Length; j++)
                {
                    if (b[minIndex] > b[j])
                    {
                        minIndex = j;
                    }
                }

                int temp = b[i];
                b[i] = b[minIndex];
                b[minIndex] = temp;
            }

            return b;
        }

        public static int[] bubbleSort(int[] a)
        {
            int[] b = new int [a.Length] ; 
            a.CopyTo(b,0);
            

            for(int i = 0; i < b.Length; i++) 
            {
                for (int j = 0; j < b.Length - 1; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        int temp = b[j + 1];

                        b[j + 1] = b[j];

                        b[j] = temp;
                    }
                }
            }

            return b;
        }

        static void Main(string[] args)
        {
            int[] a = { 4, 78, 34, 213, 768, 45, 1, 24, 65, 1, 3456, 2, 54, 87, 54, 34, 90, 0 };

            //int[] b = bubbleSort(a);
            int[] b = selectionSort(a);

            for (int i = 0; i < b.Length; i++)
            {
                System.Console.WriteLine(b[i]);
            }
        }
    }
}
