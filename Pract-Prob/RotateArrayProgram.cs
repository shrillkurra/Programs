using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class RotateArrayProgram
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int numslen = nums.Length;
            reverse(nums, 0, numslen - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, numslen - 1);

        }
        public void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;

            }
        }

        static void Main(string[] args)
        {
            int[] inputarray = new int[] {1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            RotateArrayProgram ra = new RotateArrayProgram();
            ra.Rotate(inputarray,k);
            Console.WriteLine("Just checking if it got rotated, this is not the whole array : "+inputarray[0]);
        }
    }
}
