using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class FriendScore
    {
        public int HighestScore(string[] friends)
        {
            return -1;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            FriendScore friendScore = new FriendScore();
            do
            {
                string[] values = input.Split(',');
                int validationOp = friendScore.HighestScore(values);
                Console.WriteLine(validationOp);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}