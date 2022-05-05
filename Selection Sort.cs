using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01._05._22_Sorting
{
    internal class SelectionSort : BubbleSort
    {
        private Stopwatch Timers = new Stopwatch();
        public override void Sort(int[] arr, Stopwatch Timers)
        {
            Timers.Start();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int Min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[Min])
                    {
                        arr[Min] = j;
                    }
                }

                while (arr[Min]!= arr[i])
                {
                    var Temp = arr[Min];   
                    arr[Min] = arr[i];
                    arr[i] = Temp;
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
        public override void BeforeSort(int[] arr)
        {
            base.BeforeSort(arr);
        }
    }
}
