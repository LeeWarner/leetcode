using System;
using System.Collections.Generic;
using System.Linq;

namespace _1450_Number_of_Students_Doing_Homework_at_a_Given_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = BusyStudent(new[] {1, 2, 3}, new[] {3, 2, 7}, 4);
            Console.WriteLine("Hello World!");
        }

        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            var students = new List<Student>();

            for (var i = 0; i < startTime.Length; i++)
            {
                students.Add(new Student(startTime[i], endTime[i]));
            }

            return students.Count(s => s.WasStudying(queryTime));
        }


    }

    class Student
    {
        public int StartTime { get; }
        public int EndTime { get; }

        public Student(int startTime, int endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool WasStudying(int query)
        {
            return query >= StartTime && query <= EndTime;
        }
    }
}
