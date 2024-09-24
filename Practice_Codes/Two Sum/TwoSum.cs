using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Codes.Two_Sum
{
    public class TwoSum
    {
        public void CallMethodForSum()
        {
            int[] sum = { 2, 7, 11, 13 };

            Console.WriteLine("Enter Target:");
            int target;

            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the target.");
            }

            TwoSum obj = new TwoSum();
            int[] result = obj.TwoSumMethod(sum, target);

            if (result != null)
            {
                Console.WriteLine($"Indices found: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No two consecutive numbers sum up to the target.");
            }
        }

        public int[] TwoSumMethod(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    return new int[] { i, i + 1 };
                }
            }
            return null;
        }
    }
}