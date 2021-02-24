using System.Collections.Generic;
using System.Linq;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Shuffle(new int[] { 2, 5, 11, 3, 4, 7 }, 3);
        }

        static int[] Shuffle(int[] nums, int n)
        {
            var firstHalf = nums.Take(n).ToArray(); ;
            var secondHalf = nums.Skip(n).Take(n).ToArray();

            var list = new List<int>();
            for (var i = 0; i < n; i++)
            {
                list.Add(firstHalf[i]);
                list.Add(secondHalf[i]);
            }

            return list.ToArray();

        }
    }
}


