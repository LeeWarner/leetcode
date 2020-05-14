using System;

namespace _771_Jewels_and_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb"));
            Console.ReadLine();
        }


        public static int NumJewelsInStones(string J, string S)
        {
            var count = 0;
            foreach(var stone in S.ToCharArray())
            {
                foreach (var jewel in J.ToCharArray())
                {
                    if (stone == jewel)
                    {
                        count += 1;
                    }
                }
            }

            return count;
        }
    }
}
