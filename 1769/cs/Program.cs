using System;
using System.Collections.Generic;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = MinOperations("001011");
        }

        public static int[] MinOperations(string boxes)
        {
            var costPerBox = new List<int>();
            for (var i = 0; i < boxes.Length; i++)
            {
                costPerBox.Add(calculateCost(i, boxes));
            }

            return costPerBox.ToArray();
        }

        private static int calculateCost(int targetBox, string boxes)
        {
            var cost = 0;
            for (var i = 0; i < boxes.Length; i++)
            {
                if (boxes[i] == '1')
                {
                    cost += Math.Abs(i - targetBox);

                }

            }
            return cost;
        }
    }
}