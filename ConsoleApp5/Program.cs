using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp5
{
    class Program
    {
        static void BubbleSort(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = 0; j < myList.Count - 1; j++)
                {
                    if (myList[j] > myList[j + 1])
                    {
                        int temp = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();



            List<int> tallista = new List<int>();
            Random slump = new Random();
            for (int i = 0; i < 100000; i++)
            {
                tallista.Add(slump.Next(1000000));
            }
            sw.Start();
            BubbleSort(tallista);
            sw.Stop();
            Console.WriteLine("Listan är sorterad");
            Console.WriteLine("Sorteringstid: " + sw.ElapsedMilliseconds);
        }
    }
}

