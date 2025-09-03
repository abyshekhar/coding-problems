using Problem;
using System;
using System.Collections.Generic;

namespace ProblemTests
{
    public class Sample4Tests
    {
        public static void RunAllTests()
        {
            Console.WriteLine("===== Sample4 String Problem Tests =====\n");

            // Test 1: IsSubstring
            Console.WriteLine("Test 1: IsSubstring");
            Console.WriteLine(Sample4.IsSubstring("hello world", "world")); // true
            Console.WriteLine(Sample4.IsSubstring("hello world", "abc"));   // false
            Console.WriteLine();

            // Test 2: ReverseEveryKSubstring
            Console.WriteLine("Test 2: ReverseEveryKSubstring");
            Console.WriteLine(Sample4.ReverseEveryKSubstring("abcdefg", 2)); // "badcfeg"
            Console.WriteLine(Sample4.ReverseEveryKSubstring("abcdef", 3));  // "cbafed"
            Console.WriteLine();

            // Test 3: GetAllSubstrings
            Console.WriteLine("Test 3: GetAllSubstrings");
            var substrings = Sample4.GetAllSubstrings("abc");
            Console.WriteLine(string.Join(", ", substrings)); // a, ab, abc, b, bc, c
            Console.WriteLine();

            // Test 4: LongestUniqueSubstring
            Console.WriteLine("Test 4: LongestUniqueSubstring");
            Console.WriteLine(Sample4.LongestUniqueSubstring("abcabcbb")); // "abc"
            Console.WriteLine(Sample4.LongestUniqueSubstring("bbbbb"));    // "b"
            Console.WriteLine();

            // Test 5: CountSubstringOccurrences
            Console.WriteLine("Test 5: CountSubstringOccurrences");
            Console.WriteLine(Sample4.CountSubstringOccurrences("abcababcab", "ab")); // 4
            Console.WriteLine(Sample4.CountSubstringOccurrences("aaaaa", "aa"));      // 2
            Console.WriteLine();

            // Test 6: IsPalindrome
            Console.WriteLine("Test 6: IsPalindrome");
            Console.WriteLine(Sample4.IsPalindrome("abba")); // true
            Console.WriteLine(Sample4.IsPalindrome("abc"));  // false
            Console.WriteLine();

            // Test 7: LongestPalindromicSubstring
            Console.WriteLine("Test 7: LongestPalindromicSubstring");
            Console.WriteLine(Sample4.LongestPalindromicSubstring("babad")); // "bab" or "aba"
            Console.WriteLine(Sample4.LongestPalindromicSubstring("cbbd"));  // "bb"
            Console.WriteLine();

            // Test 8: MinWindowSubstring
            Console.WriteLine("Test 8: MinWindowSubstring");
            Console.WriteLine(Sample4.MinWindowSubstring("ADOBECODEBANC", "ABC")); // "BANC"
            Console.WriteLine(Sample4.MinWindowSubstring("a", "aa"));              // ""
            Console.WriteLine();
        }
    }
}

