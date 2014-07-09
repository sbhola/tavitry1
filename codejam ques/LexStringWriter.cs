using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    class LexStringWriter
    {
        int MinMoves(String s)
        {
            return 0;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            LexStringWriter lexStringWriter = new LexStringWriter();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(lexStringWriter.MinMoves(input));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}