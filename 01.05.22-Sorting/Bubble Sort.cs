using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace _01._05._22_Sorting
{
    internal class BubbleSort
    {
        public Random Rdm = new Random();
        private Stopwatch Timers = new Stopwatch();
        public virtual void Sort(int[]arr, Stopwatch Timers)
        {
            Timers.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var Temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = Temp;
                    }
                }
            }
           
            Console.WriteLine("After Sort :\n ");
            foreach (var item in arr)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(" "+ item);
                Console.ResetColor();
            }
            Console.WriteLine("\n");

            Timers.Stop();
            TimeSpan TimeTaken = Timers.Elapsed;

            string foo = "Time Take : " + TimeTaken.ToString(@"m\:ss\:fff");
            Console.WriteLine(foo);
            Timers.Reset();
        }
        public virtual void BeforeSort(int [] arr)
        {
           
            Console.WriteLine("Before Sort :");
            Array.ForEach(arr, item => Console.Write(" "+ item));

            Console.WriteLine("\n\n");
        }
        
    }
}
