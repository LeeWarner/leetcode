using System;

namespace _1317_Convert_Integer_to_the_Sum_of_Two_No_Zero_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var answer = GetNoZeroIntegers(11);
        }

        public static int[] GetNoZeroIntegers(int n)
        {
            var firstNum = 1;
            var secondNum = n - 1;

            while (firstNum.ToString().Contains('0') || secondNum.ToString().Contains('0'))
            {
                firstNum++;
                secondNum--;
            }

            return new[] {firstNum, secondNum};
        }
    }
}
