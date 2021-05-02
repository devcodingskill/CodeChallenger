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
        public string[] RevertStringArray2(string[] words)
        {

            string[] result = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                result[i] = words[words.Length - (i + 1)];


            }
            return result;
        }
        public int RevertInt2(int nums)
        {
            
            int result = 0;
            char[] numArray = nums.ToString().ToCharArray();
            char[] temp = new char[numArray.Length];

            if (numArray[0].Equals('-') || numArray[0].Equals('+'))
            {
                temp[0] = numArray[0];
                for (int i = 1; i < numArray.Length; i++)
                {
                    temp[i] = numArray[numArray.Length - (i)];
                }
            }
            else
            {

                for (int i = 0; i < numArray.Length; i++)
                {

                    temp[i] = numArray[numArray.Length - (i + 1)];
                }
            }
           // var t = new string(temp);
            result = int.Parse(new string(temp));
            return result;

        }
        
    }
}
