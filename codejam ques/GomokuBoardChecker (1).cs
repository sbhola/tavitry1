using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    public class GomokuBoardChecker
    {
        String Check(String[] board) 
        {
            //Your code goes here
            return string.Empty;
        }
        
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            GomokuBoardChecker gomokuBoardChecker = new GomokuBoardChecker();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(gomokuBoardChecker.Check(input.Split(',')));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
