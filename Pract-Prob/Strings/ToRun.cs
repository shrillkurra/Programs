using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob.Strings
{
    class ToRun
    {
        static void Main(string[] args)
        {
            //FirstUniqueCharacterinaStringProgram fu = new FirstUniqueCharacterinaStringProgram();
            //int c = fu.FirstUniqChar("loveleetcode");
            //Console.WriteLine(c);


            //ReverseStringProblem rs = new ReverseStringProblem();
            //char[] some = { 'a','p','p','l','e' };
            //rs.ReverseString(some);
            //Console.WriteLine(some);


            //ValidAnagramProgram va = new ValidAnagramProgram();
            //bool result = va.IsAnagram("anagram", "nagaram");
            //Console.WriteLine(result);

            ValidPalindromeProgram vp = new ValidPalindromeProgram();
            bool result = vp.IsPalindrome("adda");
            Console.WriteLine(result);
        }
    }
}
