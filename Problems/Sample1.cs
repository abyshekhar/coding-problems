using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public static class Sample1
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            char[] output = new char[input.Length];
            int j = 0;
            for (int i = input.ToCharArray().Length - 1; i >= 0; i--)
            {
                output[j] = input[i];
                j++;
            }
            return new string(output);
        }
        public static string ReverseIndividualWordsInASentence(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            string[] words = input.Split(" ");
            string[] reverseWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                reverseWords[i] = Sample1.ReverseString(words[i]);
            }
            return string.Join(" ", reverseWords);
        }
        public static string[] ExtractWords(string input)
        {
            string[] words = input.Split(" ");
            return words;
        }
        public static string ExtractLettersFromString(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            string[] words = input.Split(" ");
            string sanitizedString = string.Empty;
            foreach (string word in words)
            {
                string sanitizedWord = new string(word.Where(char.IsLetter).ToArray());
                sanitizedString += sanitizedWord + " ";
            }
            return sanitizedString;
        }
        public static string ExtractNumbersFromString(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            string sanitizedString = new string(input.Where(char.IsDigit).ToArray());
            return sanitizedString;
        }

        //Level 1 – Basics
        //1. Reverse a string
        static string ReverseString1(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        //2. Reverse an array
        static int[] ReverseArray1(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        //3. Find minimum and maximum in an array
        public static (int, int) FindMinMax(int[] arr)
        {
            return (arr.Min(), arr.Max());
        }

        //4. Count vowels and consonants in a string
        public static (int, int) CountVowelsConsonants(string input)
        {
            int vowels = 0, consonants = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c)) vowels++;
                else if (Char.IsLetter(c)) consonants++;
            }
            return (vowels, consonants);
        }

        //1. Check if a string is a palindrome
        public static bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j]) return false;
                i++; j--;
            }
            return true;
        }

        //2. Check if two strings are anagrams
        /* 
         An anagram string refers to a word, phrase, or name formed by rearranging the letters of another, using all the original letters exactly once. 
        Essentially, two strings are considered anagrams if they contain the exact same characters with the same frequencies, but possibly in a different order. 
        For example: "listen" and "silent" are anagrams, "heart" and "earth" are anagrams, and "triangle" and "integral" are anagrams.
         */
        public static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            return String.Concat(s1.OrderBy(c => c)) == String.Concat(s2.OrderBy(c => c));
        }

        //3. Find the missing number in a sequence(1..n)
        public static int MissingNumber(int[] arr, int n)
        {
            int total = n * (n + 1) / 2;
            return total - arr.Sum();
        }

        //4. Find duplicate elements in an array
        public static IEnumerable<int> FindDuplicates(int[] arr)
        {
            return arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        }

        //5. Move zeroes to the end of an array
        public static void MoveZeroes(int[] arr)
        {
            int index = 0;
            foreach (int num in arr)
                if (num != 0) arr[index++] = num;
            while (index < arr.Length) arr[index++] = 0;
        }

        //1. Longest substring without repeating characters
        public static int LongestUniqueSubstring(string s)
        {
            var set = new HashSet<char>();
            int left = 0, maxLen = 0;
            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right])) set.Remove(s[left++]);
                set.Add(s[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            return maxLen;
        }

        //2. Maximum subarray sum(Kadane’s Algorithm)
        public static int MaxSubArray(int[] nums)
        {
            int max = nums[0], current = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                current = Math.Max(nums[i], current + nums[i]);
                max = Math.Max(max, current);
            }
            return max;
        }

        //3. Check if a string of parentheses is valid
        public static bool IsValidParentheses(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[') stack.Push(c);
                else
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '[')) return false;
                }
            }
            return stack.Count == 0;
        }

        //4. Find the majority element in an array
        public static int MajorityElement(int[] nums)
        {
            int count = 0, candidate = 0;
            foreach (int num in nums)
            {
                if (count == 0) candidate = num;
                count += (num == candidate) ? 1 : -1;
            }
            return candidate;
        }

        //5. Word frequency counter from a sentence
        public static Dictionary<string, int> WordFrequency(string sentence)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.GroupBy(w => w.ToLower())
            .ToDictionary(g => g.Key, g => g.Count());
        }

    }

}
