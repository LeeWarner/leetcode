using System;
using System.Linq;

namespace _1281_Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int SubtractProductAndSum(int n)
        {
            var nString = n.ToString();

            var product = 1;
            var sum = 0;

            foreach (var c in nString)
            {
                var digit = int.Parse(c.ToString());
                product *= digit;
                sum += digit;
            }

            return product - sum;
        }
    }
}
