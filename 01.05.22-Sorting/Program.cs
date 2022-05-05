using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace _01._05._22_Sorting
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

            BubbleSort Sort1 = new BubbleSort();
            Stopwatch wt = new Stopwatch();
            var GetRandom = new List<int>(Enumerable.Range(1, 90000));
            var MixedArray = GetRandom.OrderBy(a => Sort1.Rdm.Next()).ToArray();

        Menu:
            List<string> ListMenu = new List<string>();
            Console.WriteLine("Menu For Select Algorithm");
            ListMenu.Add("1.Bubble Sort");
            ListMenu.Add("2.Selection Sort");
            ListMenu.Add("3.Insertion Sort");
            ListMenu.Add("4.Merge Sort");
            ListMenu.Add("9.Exit");
            foreach ( var item in ListMenu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Select :");
            var Option = int.Parse(Console.ReadLine());
            
           
            switch (Option)
            {
                case 1:
                    //Code for Bubble Sort
                    BubbleSort();
                    Sort1.BeforeSort(MixedArray);
                    Sort1.Sort(MixedArray, wt);
                    goto Menu;
                case 2:
                    //Code for Selection Sort
                    SelectionSort();
                    SelectionSort Sort2 = new SelectionSort();
                    Sort2.BeforeSort(MixedArray);
                    Sort2.Sort(MixedArray, wt);
                    goto Menu;

                case 3:
                    //Code for Insertion Sort
                    InsertionSort();
                    InsertionSort Sort3 = new InsertionSort();
                    Sort3.BeforeSort(MixedArray);
                    Sort3.Sort(MixedArray, wt);
                    goto Menu;
                case 4:
                    //Code for Merge Sort
                    MergeSort();
                    MergeSort Sort4 = new MergeSort(9000000);

                    Sort4.BeforeSort(MixedArray);
                    Sort4.Sort(MixedArray,wt);
                    goto Menu;
                case 9:
                    Console.WriteLine();
                    break;
                default:

                    break;
            }
            //Console.ReadLine();
            


            
            

            

            
            
        }



        //as a title.
        private static void BubbleSort()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Bubble Sort :\n");
            Console.ResetColor();
        }
        private static void SelectionSort()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Selection Sort :\n");
            Console.ResetColor();
        }
        private static void InsertionSort()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Insertion Sort :\n");
            Console.ResetColor();
        }
        private static void MergeSort()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Merge Sort :\n");
            Console.ResetColor();
        }
    }
}
