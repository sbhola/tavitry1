using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class RGB
    {
        int GetLeast(string[] picture)
        {
            //Your code goes here
            return Int32.MinValue;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            RGB rgbSolver = new RGB();
            do
            {
                string[] picture = input.Split(',');
                Console.WriteLine(rgbSolver.GetLeast(picture));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}

