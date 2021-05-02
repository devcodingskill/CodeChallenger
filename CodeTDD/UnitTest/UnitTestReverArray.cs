using CodeTDD;
using NUnit.Framework;

namespace UnitTest
{
    public class UnitTestReverArray
    {
        ReverArray reverInt;
          
            [SetUp]
            public void Setup()
            {
               reverInt = new ReverArray();
            }

            [Test]
            [TestCase(new int[] { 1, 2, 5 }, new int[] { 5, 2, 1 })]
            [TestCase(new int[] { 3, -3, 5 },new int[] { 5, -3,3 })]
            [TestCase(new int[] { 3, 2, 3 }, new int[] { 3, 2,3 })]
            [TestCase(new int[] { 1, 2, 3 },  new int[] { 3, 2,1 })]
            public void TestingReverArrayInt(int[] nums, int[] expected)
            {
                   var result= reverInt.ReverIntArray2(nums);
                    Assert.AreEqual(expected, result);
            }


        [Test]
        [TestCase(new string[] { "me", "hit", "you" }, new string[] { "you", "hit", "me" })]
        //[TestCase(new string[] { 3, -3, 5 }, new string[] { 5, -3, 3 })]
        //[TestCase(new string[] { 3, 2, 3 }, new string[] { 3, 2, 3 })]
        //[TestCase(new string[] { 1, 2, 3 }, new string[] { 3, 2, 1 })]
        public void TestingReverStringInt(string[] words, string[] expected)
        {
            var result = reverInt.RevertStringArray2(words);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase( 123,321)]
        [TestCase(-123, -321)]
        //[TestCase(new string[] { 3, -3, 5 }, new string[] { 5, -3, 3 })]
        //[TestCase(new string[] { 3, 2, 3 }, new string[] { 3, 2, 3 })]
        //[TestCase(new string[] { 1, 2, 3 }, new string[] { 3, 2, 1 })]
        public void TestingReverInt(int nums, int expected)
        {
            var result = reverInt.RevertInt2(nums);
            Assert.AreEqual(expected, result);
        }
    }
    
}
