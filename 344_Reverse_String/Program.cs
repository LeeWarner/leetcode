using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace _344_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            ReverseString("hello".ToCharArray());

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }


        //1407 Ticks
        //O(n)
        public static void ReverseString(char[] s)
        {
            for (var i = 0; i < s.Length / 2; i++)
            {
                var topIndex = s.Length - 1 - i;
                var topChar = s[topIndex];
                s[topIndex] = s[i];
                s[i] = topChar;
            }
        }


        // //Linq
        // // 102414 Ticks
        // public static void ReverseString(char[] s)
        // {
        //     var x = s.Reverse().ToArray();
        //
        //     for (var i = 0; i < s.Length; i++)
        //     {
        //         s[i] = x[i];
        //     }
        // }
    }
}