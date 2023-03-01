using System;
using System.Collections.Generic;
using System.Linq;

namespace zadList1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int last = listOfNumbers[listOfNumbers.Count-1];
            listOfNumbers.RemoveAll(x => x == last);
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[1]==last)
                {
                    listOfNumbers.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", listOfNumbers));

        }
    }
}
