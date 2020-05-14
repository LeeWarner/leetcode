using System;
using System.Linq;

namespace _1295_Find_NUmbers_with_Even_Number_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int FindNumbers(int[] nums)
        {
            return nums.Count(num => num.ToString().Length % 2 == 0);
        }
    }
}
