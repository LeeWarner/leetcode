using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Add_Two_Numbers
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var l1 = new ListNode(9);
            // var l2 = new ListNode(1,
            //     new ListNode(9,
            //         new ListNode(9,
            //             new ListNode(9,
            //                 new ListNode(9,
            //                     new ListNode(9,
            //                         new ListNode(9,
            //                             new ListNode(9,
            //                                 new ListNode(9,
            //                                     new ListNode(9))))))))));

            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var answer = AddTwoNumbers(l1, l2);
            Console.WriteLine("Hello World!");
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var firstListDigits = new List<int>();
            var secondListDigits = new List<int>();

            var l1Node = l1;
            do
            {
                firstListDigits.Add(l1Node.val);
                l1Node = l1Node.next;
            } while (l1Node != null);

            var l2Node = l2;
            do
            {
                secondListDigits.Add(l2Node.val);
                l2Node = l2Node.next;
            } while (l2Node != null);


            firstListDigits.Reverse();
            secondListDigits.Reverse();

            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            foreach (var digit in firstListDigits)
            {
                sb1.Append(digit);
            }

            foreach (var digit in secondListDigits)
            {
                sb2.Append(digit);
            }

            var string1 = sb1.ToString();
            var string2 = sb2.ToString();

            var longestStringLength = string1.Length > string2.Length ? string1.Length : string2.Length;

            string1 = string1.PadLeft(longestStringLength, '0');
            string2 = string2.PadLeft(longestStringLength, '0');

            var sb = new StringBuilder();
            var carry = 0;
            for (var i = longestStringLength - 1; i >= 0; i--)
            {
                var firstDigit = string1[i].ToString();
                var secondDigit = string2[i].ToString();

                var sum = Convert.ToInt32(firstDigit) + Convert.ToInt32(secondDigit) + carry;

                if (sum > 9)
                {
                    sb.Append(sum - 10);
                    carry = 1;
                }
                else
                {
                    sb.Append(sum);
                    carry = 0;
                }
            }

            if (carry > 0)
            {
                sb.Append(carry);
            }

            var answerString = sb.ToString().ToList();
            var result = new ListNode(0) {next = MakeNodes(answerString)};

            return result.next;
        }

        private static ListNode MakeNodes(List<char> answerString)
        {
            switch (answerString.Count)
            {
                case 0:
                    return null;
                case 1:
                    return new ListNode(Convert.ToInt32(answerString[0].ToString()), MakeNodes(new List<char>()));
                default:
                {
                    var firstVal = answerString[0];
                    var secondVal = answerString[1];

                    return new ListNode(Convert.ToInt32(firstVal.ToString()), MakeNodes(answerString.Skip(1).ToList()));
                }
            }
        }
    }
}