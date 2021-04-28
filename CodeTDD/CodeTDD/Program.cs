using System;

namespace CodeTDD
{
    class Program
    {
        static void Main(string[] args)
        {
           //  Console.WriteLine("Hello World!");
            //Testing
            NumberSum numberSum = new NumberSum();
            //testing data
            int[] nums = new int[] { 3, 3 };
            int tarket = 6;
            var resutl = numberSum.TwoSum(nums, tarket);
            Console.ReadLine();
        }
    }
}
