﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChislaKvadrati
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = nums.Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x)).ToList();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}