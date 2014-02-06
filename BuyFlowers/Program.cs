using System;
using System.Linq;

namespace BuyFlowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] costs;
            int flowers, friends;
            if (GetInput(out flowers, out  friends, out costs) == 0)
            {
                var spentMoney = BuyFlowers(friends, costs);
                Console.WriteLine(spentMoney);
            }

            Console.WriteLine("Press any key to excape...");
            Console.ReadLine();
        }

        /// <summary>
        /// Fills input variable and validates values
        /// </summary>
        /// <returns>0 when input is valid, 1 when input is invalid</returns>
        private static int GetInput(out int flowers, out int friends, out double[] costs)
        {
            flowers = 0;
            friends = 0;
            costs = null;
            var kNInput = Console.ReadLine().Trim().Split(' ')
                                 .Where(t => !string.IsNullOrEmpty(t)).ToArray();
            var costsInput = Console.ReadLine().Trim().Split(' ')
                                    .Where(t => !string.IsNullOrEmpty(t)).ToArray();

            if (kNInput.Count() != 2)
            {
                Console.WriteLine("K, N input is invalid");
                return 1;
            }

            if (!Int32.TryParse(kNInput[0].Trim(), out flowers) || flowers < 1 || flowers > 100)
            {
                Console.WriteLine("N input is invalid");
                return 1;
            }

            if (!Int32.TryParse(kNInput[1].Trim(), out friends) || friends < 1 || friends > 100)
            {
                Console.WriteLine("K input is invalid");
                return 1;
            }

            if (costsInput.Length != flowers)
            {
                Console.WriteLine("Array of costs has a wrong size");
                return 1;
            }

            costs = new double[flowers];
            for (int i = 0; i < costsInput.Length; i++)
            {
                double cost;
                if (!Double.TryParse( costsInput[i], out cost) || cost <= 0 || cost > 1000)
                {
                    Console.WriteLine("Cost input is invalid");
                    return 1;
                }
                costs[i] = cost;
            }

            return 0;
        }

        /// <summary>
        /// Returns minimum money sum sufficient to buy flowers
        /// </summary>
        /// <param name="friends">Number of friends</param>
        /// <param name="costs">Array of flowers costs</param>
        /// <remarks>
        /// Friends buy flower one to another since the most expensive while all flowers while all flowers will not be bought. 
        /// </remarks>
        private static double BuyFlowers(int friends, double[] costs)
        {
            double spentMoney = 0;
            var friendsLast = friends;
            var buyCircle = 1;
            foreach (var cost in costs.OrderByDescending(t => t))
            {
                spentMoney += buyCircle * cost;
                friendsLast--;
                if (friendsLast == 0)
                {
                    buyCircle++;
                    friendsLast = friends;
                }
            }

            return spentMoney;
        }
    }
}
