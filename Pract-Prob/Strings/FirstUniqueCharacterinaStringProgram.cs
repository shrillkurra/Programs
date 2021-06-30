using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class FirstUniqueCharacterinaStringProgram
    {
        public int FirstUniqChar(string s)
        {
            char cha = another(s);
            int index = 0;
            foreach (char c in s)
            {
                if (c == cha)
                {
                    return index;
                }
                index++;

            }
            return -1;
        }

        public char another(string s)
        {
            Hashtable uniqchar = new Hashtable();
            foreach (char c in s)
            {
                if (uniqchar.ContainsKey(c))
                {
                    uniqchar[c] = (int)uniqchar[c] + 1;
                }
                else
                {
                    uniqchar.Add(c, 1);
                }
            }
            foreach (char c in s)
            {
                if ((int)uniqchar[c] == 1)
                {
                    return c;
                }
            }
            return '0';
        }

      
    }
}
