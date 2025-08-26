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
        // ------------------------------
        // 1. First Non-Repeating Character
        // Problem: Find the first character in a string that does not repeat.
        // Example: "swiss" -> 'w', "aabbcc" -> '\0'
        // ------------------------------
        [TestCase("swiss", ExpectedResult = 'w')]
        [TestCase("level", ExpectedResult = 'v')]
        [TestCase("aabbcc", ExpectedResult = '\0')] // none found
        [TestCase("racecar", ExpectedResult = 'e')]
        [TestCase("a", ExpectedResult = 'a')]
        public char FirstNonRepeatingCharTests(string input)
        {
            return Sample3.FirstNonRepeatingChar(input);
        }

        // ------------------------------
        // 2. Reverse Words in a Sentence
        // Problem: Reverse the order of words in a sentence.
        // Example: "Hello World" -> "World Hello"
        // ------------------------------
        [TestCase("Hello World", ExpectedResult = "World Hello")]
        [TestCase("  The sky is blue  ", ExpectedResult = "blue is sky The")]
        [TestCase("a good   example", ExpectedResult = "example good a")]
        [TestCase("single", ExpectedResult = "single")]
        public string ReverseWordsTests(string input)
        {
            return Sample3.ReverseWords(input);
        }

        // ------------------------------
        // 3. Two Sum Problem
        // Problem: Find indices of the two numbers in an array that add up to a given target.
        // Example: [2,7,11,15], target=9 -> [0,1]
        // ------------------------------
        [Test]
        public void TwoSumTests()
        {
            var res1 = Sample3.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.That(res1, Is.EquivalentTo(new int[] { 0, 1 }));

            var res2 = Sample3.TwoSum(new int[] { 3, 2, 4 }, 6);
            Assert.That(res2, Is.EquivalentTo(new int[] { 1, 2 }));

            var res3 = Sample3.TwoSum(new int[] { 3, 3 }, 6);
            Assert.That(res3, Is.EquivalentTo(new int[] { 0, 1 }));

            var res4 = Sample3.TwoSum(new int[] { 1, 2, 5, 7 }, 12);
            Assert.That(res4, Is.EquivalentTo(new int[] { 2, 3 }));
        }

        // ------------------------------
        // 4. FizzBuzz
        // Problem: Print numbers from 1 to n. For multiples of 3, print "Fizz";
        // for multiples of 5, print "Buzz"; for multiples of both, print "FizzBuzz".
        // Example: n=5 -> ["1", "2", "Fizz", "4", "Buzz"]
        // ------------------------------
        [Test]
        public void FizzBuzzTests()
        {
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
            var result = Sample3.FizzBuzz(5);
            Assert.That(result, Is.EqualTo(expected));

            var extended = Sample3.FizzBuzz(15);
            Assert.That(extended[2], Is.EqualTo("Fizz"));       // 3rd element (3) -> Fizz
            Assert.That(extended[4], Is.EqualTo("Buzz"));       // 5th element (5) -> Buzz
            Assert.That(extended[14], Is.EqualTo("FizzBuzz"));  // 15th element -> FizzBuzz
        }

        // ------------------------------
        // 5. Fibonacci Number
        // Problem: Find the nth Fibonacci number.
        // Example: n=5 -> 5, n=10 -> 55
        // ------------------------------
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(10, ExpectedResult = 55)]
        [TestCase(15, ExpectedResult = 610)]
        public int FibonacciTests(int n)
        {
            return Sample3.Fibonacci(n);
        }
    }
}

