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
            Assert.That(Sample3.FirstNonRepeatingChar("swiss"), Is.EqualTo('w'));
            Assert.That(Sample3.FirstNonRepeatingChar("aabbcc"), Is.EqualTo('\0'));
        }

        [Test]
        public void Test_ReverseWords()
        {
            Assert.That(Sample3.ReverseWords("  hello world  "), Is.EqualTo("world hello"));
            Assert.That(Sample3.ReverseWords("the sky is blue"), Is.EqualTo("blue is sky the"));
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
            Assert.That(Sample3.MissingNumber(nums), Is.EqualTo(2));

            nums = new int[] { 0, 1 };
            Assert.That(Sample3.MissingNumber(nums), Is.EqualTo(2));
        }

        [Test]
        public void Test_MaxSubArray()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.That(Sample3.MaxSubArray(nums), Is.EqualTo(6));

            nums = new int[] { 1 };
            Assert.That(Sample3.MaxSubArray(nums), Is.EqualTo(1));
        }
    }
}
