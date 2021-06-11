using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class StocksProgram
    {
        public int MaxProfit(int[] prices)
        {
            int priceslen = prices.Length;
            int sell = 0;
            for (int i = 0; i < priceslen - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    sell += prices[i + 1] - prices[i];
                }
                else if (prices[i] > prices[i + 1])
                {
                    continue;
                }
                else
                {
                    continue;
                }
            }
            return sell;
        }
        static void Main(string[] args)
        {
            int[] inputarray = new int[] { 7, 1, 5, 3, 6, 4 };
            StocksProgram sp = new StocksProgram();
            int result = sp.MaxProfit(inputarray);
            Console.WriteLine(result);

        }
    }
}
