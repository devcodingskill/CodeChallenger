using System;
namespace CodeTDD
{
    public class ReverArray
    {
        public ReverArray()
        {
            
        }
        public int[] ReverIntArray2(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums.Length - (i + 1)];


            }

            return result;
        }
    }
}
