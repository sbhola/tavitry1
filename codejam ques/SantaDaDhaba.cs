using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class SantaDaDhaba
    {
        int MaxDays(string[] prices, int budget)
        {
            //Your code goes here
            return -1;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            SantaDaDhaba dhaba = new SantaDaDhaba();

            do
            {
                var inputParts = input.Split('|');
                string[] prices = inputParts[0].Split(',');
                Console.WriteLine(dhaba.MaxDays(prices, Int32.Parse(inputParts[1])));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}