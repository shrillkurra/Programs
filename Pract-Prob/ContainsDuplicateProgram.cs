using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class ContainsDuplicateProgram
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
            ContainsDuplicateProgram cd = new ContainsDuplicateProgram();
            bool answer = cd.ContainsDuplicate(nums);
            Console.WriteLine(answer);

        }
    }
}
