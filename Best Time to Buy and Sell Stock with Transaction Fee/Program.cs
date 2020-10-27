using System;

namespace Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new int[] { 1, 3, 2, 8, 4, 9 };
            Console.WriteLine(MaxProfit(prices, 2));
        }

        static int MaxProfit(int[] prices, int fee)
        {
            int length = prices.Length;
            if (length == 0) return 0;
            int i = 0;
            int min = 0, max = 0;
            int maxProfit = 0;
            while (i < length - 1)
            {
                while (i < length - 1 && prices[i] > prices[i + 1]) i++;
                min = prices[i];
                while (i < length - 1 && prices[i] < prices[i + 1]) i++;
                max = prices[i];
                maxProfit += (max - min) - fee;
            }
            return maxProfit;
        }
    }
}
