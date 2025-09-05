using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.NUnit.Tests
{
    [TestFixture]
    public class Sample1Tests
    {
        [Test]
        public void Test_ReverseString()
        {
            Assert.That(Sample1.ReverseString("Sudhanshu Shekhar"), Is.EqualTo("rahkehS uhsnahduS"));
        }
        [TestCase("nitin", ExpectedResult = "nitin")]
        [TestCase("Hello World!",ExpectedResult ="!dlroW olleH")]
        public string ReverseStringTests(string str)
        {
            return Sample1.ReverseString(str);
        }

        [TestCase("Hello World",ExpectedResult ="olleH dlroW")]
        [TestCase("Hello",ExpectedResult ="olleH")]
        public string ReverseIndividualWordsInASentenceTests(string str)
        {
            return Sample1.ReverseIndividualWordsInASentence(str);
        }
        [TestFixture]
        public class KadaneTests
        {
            [TestCase(new int[] { 1, -2, 3, 4, -1, 2, 1, -5, 4 }, 9)]
            [TestCase(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 7)]
            [TestCase(new int[] { 5, 4, -1, 7, 8 }, 23)]
            [TestCase(new int[] { -1, -2, -3, -4 }, -1)]
            [TestCase(new int[] { 2, 3, -8, 7, -1, 2, 3 }, 11)]
            [TestCase(new int[] { 1, 2, 3, -2, 5 }, 9)]
            [TestCase(new int[] { -2, -3, 4, -1, -2, 1, 5, -3, 2, 2 }, 9)]
            [TestCase(new int[] { 100, -90, 80, -70, 60, -50 }, 100)]
            [TestCase(new int[] { 0, 0, 0, 0 }, 0)]
            [TestCase(new int[] { 8 }, 8)]
            public void TestMaxSubarraySum(int[] nums, int expected)
            {
                Assert.That(Sample1.MaxSubArray(nums), Is.EqualTo(expected));
            }
        }

    }
}
