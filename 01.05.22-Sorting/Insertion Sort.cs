using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01._05._22_Sorting
{
    internal class InsertionSort : BubbleSort
    {
        private Stopwatch Timers = new Stopwatch();
        public override void BeforeSort(int[] arr)
        {
            base.BeforeSort(arr);   
        }

        public override void Sort(int[] arr, Stopwatch Timers)
        {
            Timers.Start();
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j > 0; j--)
                {
                    if (arr[j] < arr[j-1])
                    {
                        var Temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = Temp; 
                    }
                }
               
            }

            Console.WriteLine("After Sort :\n ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");

            Timers.Stop();
            TimeSpan TimeTaken = Timers.Elapsed;

            string foo = "Time Take : " + TimeTaken.ToString(@"m\:ss\:fff");
            Console.WriteLine(foo);
            Timers.Reset();
        }
    }
}
