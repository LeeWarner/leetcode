using System;

namespace _1342_Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public int NumberOfSteps(int num)
        {
            var stepCount = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    stepCount++;
                }
                else
                {
                    num -= 1;
                    stepCount++;
                }
            }


            return stepCount;
        }
    }
}
