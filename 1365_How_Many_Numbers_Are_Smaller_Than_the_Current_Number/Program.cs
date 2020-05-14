using System;
using System.Collections.Generic;
using System.Linq;

namespace _1365_How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            return nums.Select(i => nums.Count(j => j < i)).ToArray();
        }
    }
}
