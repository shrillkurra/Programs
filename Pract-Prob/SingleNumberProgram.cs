using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class SingleNumberProgram
    {
        public int SingleNumber(int[] nums)
        {
            Hashtable numberhash = new Hashtable();
            for(int i = 0; i < nums.Length; i++)
            {
                if (!numberhash.ContainsKey(nums[i]))
                {
                    numberhash.Add(nums[i],1);
                }
                else
                {
                    int num = (int)numberhash[nums[i]];
                    numberhash[nums[i]] = num + 1;
                }
            }
            for(int i=0; i<nums.Length;i++)
            {
                int one = 1;
                if ((int)numberhash[nums[i]] == one)
                {
                    return nums[i];
                }

            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[]{2,2,1};
            SingleNumberProgram sn = new SingleNumberProgram();
            int result = sn.SingleNumber(nums);
            Console.WriteLine(result);
        }
    }
}
