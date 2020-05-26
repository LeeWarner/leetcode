using System;
using System.Linq;

namespace _414_Third_Maximum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = ThirdMax(new[] {2, 2, 3, 1});
            Console.WriteLine("Hello World!");
        }


        public static int ThirdMax(int[] nums)
        {
            var numbers = nums.OrderByDescending(n => n).Distinct().ToList();
            return numbers.Count < 3 ? numbers.First() : numbers.Skip(2).Take(1).Single();
        }
    }
}