using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    class Pool
    {
        int RackMoves(int[] triangle)
        {
            //Your code goes here
            return 0;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            Pool pool = new Pool();
            String input = Console.ReadLine();
            do
            {
                int[] triangle = Array.ConvertAll<string,int>(input.Split(','),delegate(string s) { return Int32.Parse(s); });
                Console.WriteLine(pool.RackMoves(triangle));
                input = Console.ReadLine();
            } while (input!= "-1");
        }
        #endregion

    }
}