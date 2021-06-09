using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pract_Prob
{
    public class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for(int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if(nums[j] == target - nums[i])
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
            return output;

        }
        static void Main(string[] args)
        {
            int[] numbers = {3,2,4};
            int tag = 6;
            TwoSum twosumobj = new TwoSum();
            int[] output = twosumobj.TwoSums(numbers, tag);

            Console.WriteLine(output[0]+" "+ output[1]);
        }
    }

 }
