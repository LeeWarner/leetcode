using System;
using System.Collections.Generic;
using System.Linq;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = RunningSum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(string.Join(',', answer));
        }

        static int[] RunningSum(int[] nums)
        {
            var answer = new List<int>();

            for (var i = 1; i <= nums.Length; i++)
            {
                answer.Add(nums.Take(i).Sum());
            }

            return answer.ToArray();
        }
    }
}
