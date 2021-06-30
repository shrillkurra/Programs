using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pract_Prob
{
    class ValidPalindromeProgram
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            Console.WriteLine(s);
            string s_removedig = Regex.Replace(s, @"[^0-9a-z]", "");
            Console.WriteLine(s_removedig);
            char[] reversechar = s_removedig.ToCharArray();
            Array.Reverse(reversechar);
            string reverse_s = new string(reversechar);
            Console.WriteLine(reverse_s);
            if (s == reverse_s)
            {
                return true;
            }
            return false;
        }
        
    }
}
