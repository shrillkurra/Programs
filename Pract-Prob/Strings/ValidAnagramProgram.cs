using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pract_Prob.Strings
{
    class ValidAnagramProgram
    {
        public bool IsAnagram(string s, string t)
        {
            string s_result = String.Concat(s.OrderBy(c => c));
            string t_result = String.Concat(t.OrderBy(c => c));
            if (s_result == t_result)
            {
                return true;
            }
            return false;
        }
    }
}
