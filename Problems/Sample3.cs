using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
    public static class Sample3
    {
        /*
         * Problem: Find the First Non-Repeating Character in a String
         * Example:
         * Input: "swiss"
         * Output: 'w'
         * Explanation: 'w' is the first character that does not repeat.
         * Time Complexity: O(n)
         * Space Complexity: O(1) (since alphabet is finite)
         */
        public static char FirstNonRepeatingChar(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c)) dict[c]++;
                else dict[c] = 1;
            }
            foreach (char c in s)
            {
                if (dict[c] == 1) return c;
            }
            return '\0'; // no non-repeating char
        }

        /*
         * Problem: Reverse Words in a String
         * Example:
         * Input: "  hello world  "
         * Output: "world hello"
         * Explanation: Words should be reversed, extra spaces removed.
         * Time Complexity: O(n)
         * Space Complexity: O(n)
         */
        public static string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        }

        /*
         * Problem: Two Sum
         * Example:
         * Input: nums = [2,7,11,15], target = 9
         * Output: [0,1]
         * Explanation: nums[0] + nums[1] = 2 + 7 = 9
         * Time Complexity: O(n)
         * Space Complexity: O(n)
         */
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                    return new int[] { dict[complement], i };
                dict[nums[i]] = i;
            }
            return Array.Empty<int>();
        }

        /*
         * Problem: Find Missing Number
         * Example:
         * Input: nums = [3,0,1]
         * Output: 2
         * Explanation: All numbers from 0 to 3 are present except 2.
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         */
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = nums.Sum();
            return expectedSum - actualSum;
        }

        /*
         * Problem: Maximum Subarray (Kadane’s Algorithm)
         * Example:
         * Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
         * Output: 6
         * Explanation: [4,-1,2,1] has the largest sum = 6.
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         */
        public static int MaxSubArray(int[] nums)
        {
            int maxSoFar = nums[0], currentMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currentMax = Math.Max(nums[i], currentMax + nums[i]);
                maxSoFar = Math.Max(maxSoFar, currentMax);
            }
            return maxSoFar;
        }
    }
}
