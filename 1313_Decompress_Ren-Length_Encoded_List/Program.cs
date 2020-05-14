using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _1313_Decompress_Ren_Length_Encoded_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var answer = DecompressRLElist(new[] {1, 1, 2, 3});

            stopwatch.Stop();

            var elapsed = stopwatch.ElapsedMilliseconds;
        }

        public static int[] DecompressRLElist(int[] nums)
        {
            var answer = new List<int>();

            for (var i = 0; i < nums.Length; i += 2)
            {
                for (var j = 0; j < nums[i]; j++)
                {
                    answer.Add(nums[i + 1]);
                }
            }
            
            return answer.ToArray();
        }

        // public static int[] DecompressRLElist(int[] nums)
        // {
        //     var taken = 0;
        //     var answer = new List<int>();
        //
        //     while (taken < nums.Length)
        //     {
        //         var pair = nums.Skip(taken).Take(2).ToList();
        //         taken += 2;
        //         var frequency = pair.First();
        //         var val = pair.Last();
        //
        //         for (var i = 0; i < frequency; i++)
        //         {
        //             answer.Add(val);
        //         }
        //     }
        //
        //     return answer.ToArray();
        // }
    }
}
