using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    public class ComputerExpert
    {
        String[] Operate(String[] facts, String[] rules)
        {
            //Your code goes here
            return new string[] { };
        }
        
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            ComputerExpert computerExpert = new ComputerExpert();
            String input = Console.ReadLine();
            do
            {
                string[] values=input.Split('|');
                string[] result = computerExpert.Operate(values[0].Split(','), values[1].Split(';'));
                Console.WriteLine(string.Join(",", result));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
