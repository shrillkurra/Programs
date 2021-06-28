using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class MoveZerosProgram
    {
        public void MoveZeroes(int[] nums)
        {
            int numslen = nums.Length;
            int j;
            for (int i = 0; i < numslen - 1; i++)
            {
                j = i + 1;
                if (nums[i] != 0)
                {
                    continue;
                }
                else
                {
                    if (nums[j] != 0)
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            MoveZerosProgram mz = new MoveZerosProgram();
            mz.MoveZeroes(nums);
        }
    }
}
