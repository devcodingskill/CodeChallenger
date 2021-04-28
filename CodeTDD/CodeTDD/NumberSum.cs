using System;
namespace CodeTDD
{
    public class NumberSum
    {
        public NumberSum()
        {
        }
        public int[] TwoSum(int[] nums, int tarket)
        {
            int[] result = new int[2];
            bool hitTarket = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (!hitTarket)
                    {
                        if (nums[i] + nums[j] == tarket)
                        {
                            result[0] = i;
                            result[1] = j;
                        }
                    }

                }
            }
            return result;
        }
    }
}
