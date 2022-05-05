using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._05._22_Sorting
{
    internal class MergeSort : BubbleSort
    {
        private int [] Data;

        private Random generator = new Random();
        public MergeSort(int size)
        {
            Data = new int[size];

            for (int i = 0; i < size; i++)
            {
                Data[i] = 10 + generator.Next(90);
            }

          
        }
        public override void BeforeSort(int[] arr)
        {
            base.BeforeSort(arr);
        }

        public  void Sort(Stopwatch Timers)
        {
            Console.WriteLine("After Sort :\n ");
            Timers.Start();
            SortArray(0, Data.Length - 1);
            Timers.Stop();

            TimeSpan TimeTaken = Timers.Elapsed;

            string foo = "Time Taken : " + TimeTaken.ToString(@"m\:ss\:fff");
            Console.WriteLine($"{foo}\n\n");
 
        }

        public void SortArray(int l, int r)
        {
            /*
         *          variable low means left.
         *          variable high means right.
         */
            if ((r-l) >= 1)
            {
                //for split
                int m1 = (l-r)/ 2;  // for split the array. => 0,1,2, 3,4,5  => 0+5/2
                int m2 = m1 + 1;
                

                Console.WriteLine("Split : \n " + subarray( l, r));
                Console.WriteLine(" "+ subarray(l,r));
                Console.WriteLine(" "+ subarray(m2, r));

                //Split array: sort recursive
                SortArray(l, m1);
                SortArray(m2, r);
                
                Merge(l,m1,m2,r);
            }
        }


        //Method for Merge two sub array. 
        public string subarray(int l, int r)
        {

            StringBuilder temp = new StringBuilder();
            for (int i = l; i <= r  ; i++)
            {
                temp.Append(Data[i] + " ");
            }
            return temp.ToString(); 
        }
        public string ToStrings => subarray( 0, Data.Length - 1);
        public void Merge(int m2, int l, int m1, int r)
        {
            int LeftIndex = l;
            int RightIndex = m2;
            int CombineIndex = l;
            int[] Combined = new int[Data.Length];


            Console.WriteLine("merge :\n " + subarray( l, r));
            Console.WriteLine((subarray( m2, r) + " "));

            while (LeftIndex <= m1 && RightIndex <= r)
            {
                if (Data[LeftIndex] <= Data[RightIndex])
                {
                    Combined[CombineIndex++] = Data[LeftIndex++];
                }
                else
                {
                    Combined[CombineIndex++] = Data[RightIndex++];
                }
            }

            if (LeftIndex == m2)
            {
                while (RightIndex <= r)
                {
                    Combined[CombineIndex++] = Data[RightIndex];
                }
            }
            else
            {
                while (LeftIndex <= m1)
                {
                    Combined[CombineIndex++] = Data[LeftIndex++];
                }
            }

            //copying ke data asli.
            for (int i = l; i <= r; i++)
            {
                Data[i] = Combined[i];
            }

            //show
            Console.WriteLine(" " + subarray(l,r));
            Console.WriteLine();
        }
    }
}
