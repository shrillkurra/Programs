using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class ReverseIntegerProgram
    {
        //This program wil not work when there is a overflow of integer. It will work only for small numbers
        public int Reverse(int x)
        {
            int n = x;
            int result = 0;
            double max = (Math.Pow(2, 31));
            if (n >= 0 && n < max)
            {
                result = reversednumber(n);
                return result;
            }
            else if (n < 0 && n > -max)
            {
                n = -n;
                result = reversednumber(n);
                result = -result;
                return result;
            }
            else
            {
                return 0;
            }

        }
        int reversednumber(int x)
        {
            int res = 0;
            while (x > 0)
            {
                int remainder = x % 10;
                res = res * 10 + remainder;
                x = x / 10;
            }
            return res;
        }
        static void Main(string[] args)
        {
            ReverseIntegerProgram rs = new ReverseIntegerProgram();
            int result = rs.Reverse(132);
            Console.WriteLine(result);
        }
    }
}
