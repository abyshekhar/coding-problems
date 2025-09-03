using Problem;
using System;
using System.Collections.Generic;
using Xunit;

namespace Problems.xUnit.Tests
{
    public class Sample4Tests
    {
        [Theory]
        [InlineData("hello world", "world", true)]
        [InlineData("hello world", "abc", false)]
        public void Test_IsSubstring(string str, string sub, bool expected)
        {
            bool result = Sample4.IsSubstring(str, sub);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcdefg", 2, "badcfeg")]
        [InlineData("abcdef", 3, "cbafed")]
        public void Test_ReverseEveryKSubstring(string input, int k, string expected)
        {
            string result = Sample4.ReverseEveryKSubstring(input, k);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_GetAllSubstrings()
        {
            var result = Sample4.GetAllSubstrings("abc");
            var expected = new List<string> { "a", "ab", "abc", "b", "bc", "c" };
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcabcbb", "abc")]
        [InlineData("bbbbb", "b")]
        [InlineData("pwwkew", "wke")]
        public void Test_LongestUniqueSubstring(string input, string expected)
        {
            string result = Sample4.LongestUniqueSubstring(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcababcab", "ab", false, 4)]
        [InlineData("aaaaa", "aa", false, 2)]
        [InlineData("mississippi", "issi", false, 1)]  // non-overlapping
        [InlineData("mississippi", "issi", true, 2)]   // overlapping
        public void Test_CountSubstringOccurrences(string text, string pattern, bool allowOverlapping, int expected)
        {
            int result = Sample4.CountSubstringOccurrences(text, pattern, allowOverlapping);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abba", true)]
        [InlineData("abc", false)]
        [InlineData("a", true)]
        public void Test_IsPalindrome(string input, bool expected)
        {
            bool result = Sample4.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("babad", "bab")] // "aba" is also valid, we’ll allow either
        [InlineData("cbbd", "bb")]
        public void Test_LongestPalindromicSubstring(string input, string expected)
        {
            string result = Sample4.LongestPalindromicSubstring(input);

            if (input == "babad")
                Assert.Contains(result, new List<string> { "bab", "aba" });
            else
                Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("ADOBECODEBANC", "ABC", "BANC")]
        [InlineData("a", "aa", "")]
        public void Test_MinWindowSubstring(string input, string target, string expected)
        {
            string result = Sample4.MinWindowSubstring(input, target);
            Assert.Equal(expected, result);
        }
    }
}

