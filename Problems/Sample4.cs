using System;
using System.Collections.Generic;
namespace Problem
{
    public static class Sample4
    {
        /// <summary>
        /// Problem 1: Check if a string is a substring of another.
        /// Example: str = "hello world", sub = "world" → true
        /// </summary>
        public static bool IsSubstring(string str, string sub)
        {
            return str.Contains(sub);
        }

        /// <summary>
        /// Problem 2: Reverse every substring of length k.
        /// Example: str = "abcdefg", k = 2 → "badcfeg"
        /// </summary>
        public static string ReverseEveryKSubstring(string str, int k)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i += k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, arr.Length - 1);

                while (left < right)
                {
                    char temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            return new string(arr);
        }

        /// <summary>
        /// Problem 3: Print all substrings of a string.
        /// Example: str = "abc" → a, ab, abc, b, bc, c
        /// </summary>
        public static List<string> GetAllSubstrings(string str)
        {
            List<string> substrings = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j <= str.Length; j++)
                {
                    substrings.Add(str.Substring(i, j - i));
                }
            }
            return substrings;
        }

        /// <summary>
        /// Problem 4: Find the longest substring without repeating characters.
        /// Example: "abcabcbb" → "abc" (length 3)
        /// </summary>
        public static string LongestUniqueSubstring(string str)
        {
            int left = 0, maxLen = 0, start = 0;
            HashSet<char> seen = new HashSet<char>();

            for (int right = 0; right < str.Length; right++)
            {
                while (seen.Contains(str[right]))
                {
                    seen.Remove(str[left]);
                    left++;
                }
                seen.Add(str[right]);

                if (right - left + 1 > maxLen)
                {
                    maxLen = right - left + 1;
                    start = left;
                }
            }

            return str.Substring(start, maxLen);
        }

        /// <summary>
        /// Problem 5: Count occurrences of a substring.
        /// Example: text = "abcababcab", pattern = "ab" → 4
        /// </summary>
        public static int CountSubstringOccurrences(string text, string pattern)
        {
            int count = 0, index = 0;
            while ((index = text.IndexOf(pattern, index)) != -1)
            {
                count++;
                index += pattern.Length;
            }
            return count;
        }

        /// <summary>
        /// Problem 6: Check if a substring is a palindrome.
        /// Example: str = "abba", sub = "bb" → true
        /// </summary>
        public static bool IsPalindrome(string sub)
        {
            int left = 0, right = sub.Length - 1;
            while (left < right)
            {
                if (sub[left] != sub[right]) return false;
                left++;
                right--;
            }
            return true;
        }

        /// <summary>
        /// Problem 7: Find the longest palindromic substring.
        /// Example: "babad" → "bab" or "aba"
        /// </summary>
        public static string LongestPalindromicSubstring(string str)
        {
            if (string.IsNullOrEmpty(str)) return "";

            int start = 0, maxLen = 1;

            for (int i = 0; i < str.Length; i++)
            {
                ExpandAroundCenter(str, i, i, ref start, ref maxLen);     // Odd length
                ExpandAroundCenter(str, i, i + 1, ref start, ref maxLen); // Even length
            }

            return str.Substring(start, maxLen);
        }

        private static void ExpandAroundCenter(string s, int left, int right, ref int start, ref int maxLen)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > maxLen)
                {
                    start = left;
                    maxLen = right - left + 1;
                }
                left--;
                right++;
            }
        }

        /// <summary>
        /// Problem 8: Find the smallest substring containing all characters of another string.
        /// Example: str = "ADOBECODEBANC", target = "ABC" → "BANC"
        /// </summary>
        public static string MinWindowSubstring(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return "";

            Dictionary<char, int> need = new Dictionary<char, int>();
            foreach (var c in t)
            {
                if (!need.ContainsKey(c)) need[c] = 0;
                need[c]++;
            }

            Dictionary<char, int> window = new Dictionary<char, int>();
            int left = 0, right = 0, valid = 0;
            int minLen = int.MaxValue, start = 0;

            while (right < s.Length)
            {
                char c = s[right];
                if (need.ContainsKey(c))
                {
                    if (!window.ContainsKey(c)) window[c] = 0;
                    window[c]++;
                    if (window[c] == need[c]) valid++;
                }
                right++;

                while (valid == need.Count)
                {
                    if (right - left < minLen)
                    {
                        start = left;
                        minLen = right - left;
                    }

                    char d = s[left];
                    if (need.ContainsKey(d))
                    {
                        if (window[d] == need[d]) valid--;
                        window[d]--;
                    }
                    left++;
                }
            }

            return minLen == int.MaxValue ? "" : s.Substring(start, minLen);
        }
    }
}

