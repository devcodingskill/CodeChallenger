using CodeTDD;
using NUnit.Framework;

namespace UnitTest
{
    public class Tests
    {
        //We need to add referent to the project
        //Click on the project Add => referent to main project

        NumberSum numberSum;
        [SetUp]
        public void Setup()
        {
            numberSum = new NumberSum();
        }

        [Test]
        [TestCase (new int[] { 1,2,5},7,new int[] {1,2})]
        [TestCase(new int[] { 3, -3, 5 }, 0, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        public void TestingTwoSumNumber(int[] nums,int tarket, int[] expected)
        {
            var result = numberSum.TwoSum(nums,tarket);
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            // Assert.AreSame(expected, result);
            // Assert.Pass();
        }
    }
}