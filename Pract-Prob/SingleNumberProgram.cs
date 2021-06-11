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
                if (numberhash.ContainsValue(1))
                {
                    return nums[i];
                }

            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 4,1,2,1,2};
            SingleNumberProgram sn = new SingleNumberProgram();
            int result = sn.SingleNumber(nums);
            Console.WriteLine(result);
        }
    }
}
