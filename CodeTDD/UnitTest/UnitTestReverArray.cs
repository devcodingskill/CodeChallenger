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
        }
    
}
