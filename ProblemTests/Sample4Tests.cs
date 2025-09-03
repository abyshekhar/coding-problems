using NUnit.Framework;
using Problem;
using System.Collections.Generic;

namespace Problems.NUnit.Tests
{
    [TestFixture]
    public class Sample4Tests
    {
        [TestCase("hello world", "world", true)]
        [TestCase("hello world", "abc", false)]
        public void Test_IsSubstring(string text, string pattern, bool expected)
        {
            Assert.That(Sample4.IsSubstring(text, pattern), Is.EqualTo(expected));
        }

        [TestCase("abcdefg", 2, "badcfeg")]
        [TestCase("abcdef", 3, "cbafed")]
        public void Test_ReverseEveryKSubstring(string text, int k, string expected)
        {
            Assert.That(Sample4.ReverseEveryKSubstring(text, k), Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetAllSubstrings()
        {
            var result = Sample4.GetAllSubstrings("abc");
            var expected = new List<string> { "a", "ab", "abc", "b", "bc", "c" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestCase("abcabcbb", "abc")]
        [TestCase("bbbbb", "b")]
        public void Test_LongestUniqueSubstring(string text, string expected)
        {
            Assert.That(Sample4.LongestUniqueSubstring(text), Is.EqualTo(expected));
        }

        [TestCase("abcababcab", "ab", false, 4)]
        [TestCase("aaaaa", "aa", false, 2)]
        [TestCase("mississippi", "issi", false, 1)]
        [TestCase("mississippi", "issi", true, 2)]
        public void Test_CountSubstringOccurrences(string text, string pattern, bool allowOverlapping, int expected)
        {
            Assert.That(Sample4.CountSubstringOccurrences(text, pattern, allowOverlapping), Is.EqualTo(expected));
        }

        [TestCase("abba", true)]
        [TestCase("abc", false)]
        public void Test_IsPalindrome(string text, bool expected)
        {
            Assert.That(Sample4.IsPalindrome(text), Is.EqualTo(expected));
        }

        [TestCase("babad", "bab", "aba")] // can be "bab" or "aba"
        [TestCase("cbbd", "bb", null)]
        public void Test_LongestPalindromicSubstring(string text, string expected1, string expected2)
        {
            var result = Sample4.LongestPalindromicSubstring(text);
            if (expected2 == null)
                Assert.That(result, Is.EqualTo(expected1));
            else
                Assert.IsTrue(result == expected1 || result == expected2);
        }

        [TestCase("ADOBECODEBANC", "ABC", "BANC")]
        [TestCase("a", "aa", "")]
        public void Test_MinWindowSubstring(string text, string pattern, string expected)
        {
            Assert.That(Sample4.MinWindowSubstring(text, pattern), Is.EqualTo(expected));
        }
    }
}
