using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationadvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0]=="end")
                {
                    break;
                }
                switch (cmd[0])
                {
                    case "PrintEven":
                        Console.WriteLine(string.Join(' ',nums.Where(x=>x%2==0)));
                        break;
                    case "FIlter":
                        int num1 = int.Parse(cmd[2]);
                        switch (cmd[1])
                        {
                            case ">":
                                Console.WriteLine(string.Join(" ", nums.Where(x => x > num1)));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", nums.Where(x => x >= num1)));
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Contains":
                        int element = int.Parse(cmd[1]);
                        if (nums.Contains(element))
                        {
                            Console.WriteLine(nums.IndexOf(element));
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                       
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', nums.Where(x => x % 2 == 1)));

                        break;
                    case "GetSum":
                        Console.WriteLine(nums.Sum());

                        break;
                    default:
                        break;
                }
            }
        }  
    }
}
