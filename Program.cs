using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace QSort
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input array elements separated with spaces:");
            string inputString = "";

            inputString = Console.ReadLine();

           
            Debug.Assert(inputString != null, "inputString != null");
            string[] array = inputString.Split(' ');

            ArrayList arrayToSort = new ArrayList();
            foreach (var el in array)
            {
                arrayToSort.Add(Convert.ToInt32(el));
            }

            QSort.Sorter.QSort(ref arrayToSort);

            foreach (var el in arrayToSort)
            {
               Console.Write(el.ToString() + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
