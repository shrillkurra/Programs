using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class ReverseStringProblem
    {
        public void ReverseString(char[] s)
        {
            int s_length = s.Length;
            int half_length = s_length / 2;
            int last = s_length-1 ;
            char temp;
            for(int i = 0; i <= half_length-1; i++)
            {
                temp = s[i];
                s[i] = s[last];
                s[last] = temp;
                last--;
            }
        }


    }
}
