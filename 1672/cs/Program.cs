using System.Linq;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new int[][]{
                new int[] {1,2,3},
                new int[] {3,2,1}
            };
            var answer = MaximumWealth(accounts);
        }

        public static int MaximumWealth(int[][] accounts)
        {
            var customers = accounts;
            var maxWealth = -1;
            foreach (var customerAccounts in customers)
            {
                var customerWealth = customerAccounts.Sum(ca => ca);
                if (customerWealth > maxWealth)
                {
                    maxWealth = customerWealth;
                }
            }

            return maxWealth;

        }
    }


}
