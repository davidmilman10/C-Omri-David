    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace targil1
    {
        internal class Prog2
        {
            static void Main(string[] args)
            {
                int[] arr = new int[9];
                int[] arr2 = new int[9];
                int i = 0, j = 0;
                Console.WriteLine("Please Enter Numbers for the array between 0-100: ");
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    while (arr[i] < 0 || arr[i] > 100)
                    {
                        Console.Write("Number Not in Range please re enter: ");
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < arr.Length; i++)
                {
                    if (Array.IndexOf(arr, arr[i]) == Array.LastIndexOf(arr, arr[i]))
                    {
                        arr2[j] = arr[i]; j++;
                    }
                }
                Console.WriteLine("Array2 elements are: ");
                for ( i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(+arr2[i] + " ");

                }
        
         

            }

        }
    }
