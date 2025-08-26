using NUnit.Framework;
using Problem;
using System;

namespace ProblemTests
{
    [TestFixture]
    public class Sample3Tests
    {
        [Test]
        public void Test_FirstNonRepeatingChar()
        {
            Assert.AreEqual('w', Sample3.FirstNonRepeatingChar("swiss"));
            Assert.AreEqual('\0', Sample3.FirstNonRepeatingChar("aabbcc"));
        }

        [Test]
        public void Test_ReverseWords()
        {
            Assert.AreEqual("world hello", Sample3.ReverseWords("  hello world  "));
            Assert.AreEqual("blue is sky the", Sample3.ReverseWords("the sky is blue"));
        }

        [Test]
        public void Test_TwoSum()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] result = Sample3.TwoSum(nums, 9);
            CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
        }

        [Test]
        public void Test_MissingNumber()
        {
            int[] nums = { 3, 0, 1 };
            Assert.AreEqual(2, Sample3.MissingNumber(nums));

            nums = new int[] { 0, 1 };
            Assert.AreEqual(2, Sample3.MissingNumber(nums));
        }

        [Test]
        public void Test_MaxSubArray()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, Sample3.MaxSubArray(nums));

            nums = new int[] { 1 };
            Assert.AreEqual(1, Sample3.MaxSubArray(nums));
        }
    }
}
