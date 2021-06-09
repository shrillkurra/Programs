using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class RemoveDuplicatesProgram
    {
        public int RemoveDuplicates(int[] nums)
        {
            int pointarray = 0;
            int lengtharray = nums.Length;
            if (nums.Length > 0)
            {
                for (int i = 1; i <= nums.Length - 1; i++)
                {
                    if (nums[pointarray] != nums[i])
                    {
                        pointarray++;
                        nums[pointarray] = nums[i];
                    }
                }
            }
            else
            {
                return pointarray;
            }
            return pointarray + 1;

        }
        static void Main(string[] args)
        {
            RemoveDuplicatesProgram re = new RemoveDuplicatesProgram();
            int[] s = new int[] { 1, 1, 2, 3, 4 };
            int result = re.RemoveDuplicates(s);
            Console.WriteLine(result);
        }
    }
}
