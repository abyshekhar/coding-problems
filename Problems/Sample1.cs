using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Problems.Sample2;

namespace Problems
{
    public static partial class Sample1
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

        public static IList<int> FindAnagrams(string s, string p)
        {
            var res = new List<int>();
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || s.Length < p.Length) return res;
            int[] pat = new int[26];
            int[] win = new int[26];
            foreach (var ch in p) pat[ch - 'a']++;
            int left = 0, right = 0, required = p.Length;
            while (right < s.Length)
            {
                int idx = s[right] - 'a';
                win[idx]++;
                right++;
                if (right - left == p.Length)
                {
                    if (Enumerable.Range(0, 26).All(i => win[i] == pat[i]))
                        res.Add(left);
                    win[s[left] - 'a']--;
                    left++;
                }
            }
            return res;
        }

        // abcakjdfljbaceekjfh
        public static List<int> IndexesAnagramInAString(string input, string pattern)
        {
            List<int> ints = new List<int>();
            int j = 0;
            int patternLength = pattern.Length;
            for (int i = 0; i < input.Length - patternLength; i++)
            {
                string substring = input.Substring(i, patternLength);
                bool IsAnagram = string.Concat(substring.OrderBy(c => c)) == string.Concat(pattern.OrderBy(c => c));
                if (IsAnagram) ints.Add(i);
            }
            return ints;
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
        //Sudhanshu
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

        //LongestUniqueSubstring("abcabcbb"); // "abc"
        //LongestUniqueSubstring("bbbbb");    // "b"
        //LongestUniqueSubstring("pwwkew");   // "wke"
        //LongestUniqueSubstring("Sudhanshu"); // "Sudhans"
        public static string PrintLongestUniqueSubstring(string s)
        {
            var set = new HashSet<char>();
            int left = 0, maxLen = 0, startIndex = 0;

            for (int right = 0; right < s.Length; right++)
            {
                // If duplicate, shrink from left until it's removed
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                // Add current char to the set
                set.Add(s[right]);

                // Update max length and start index
                int windowLen = right - left + 1;
                if (windowLen > maxLen)
                {
                    maxLen = windowLen;
                    startIndex = left;
                }
            }

            // Extract substring
            return s.Substring(startIndex, maxLen);
        }

        //2. Maximum subarray sum(Kadane’s Algorithm)
        // 1, -2, 3, 4, -1, 2, 1, -5, 4 
        // 9
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
        public static (int maxSum, int[] subarray) KadaneWithSubarray(int[] nums)
        {
            int currentMax = nums[0];
            int maxSoFar = nums[0];
            int start = 0, end = 0, s = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > currentMax + nums[i])
                {
                    currentMax = nums[i];
                    s = i;
                }
                else
                {
                    currentMax += nums[i];
                }

                if (currentMax > maxSoFar)
                {
                    maxSoFar = currentMax;
                    start = s;
                    end = i;
                }
            }

            int[] subarray = new int[end - start + 1];
            Array.Copy(nums, start, subarray, 0, subarray.Length);

            return (maxSoFar, subarray);
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

        // Merge overlapping arrays
        //[1,2],[3,4],[1,5],[6,7]
        public static IList<int[]> MergeIntervals(IList<int[]> intervals)
        {
            if (intervals == null || intervals.Count == 0) return new List<int[]>();
            var sorted = intervals.OrderBy(i => i[0]).ToList();
            Console.WriteLine($" Sorted List of Arrays");
            foreach (var interval in sorted) Console.WriteLine($"[{string.Join(",", interval)}]");
            var result = new List<int[]>();
            int[] current = sorted[0];
            foreach (var next in sorted.Skip(1))
            {
                if (next[0] <= current[1]) // overlap
                {
                    current[1] = Math.Max(current[1], next[1]);
                }
                else
                {
                    result.Add(current);
                    current = next;
                }
            }
            result.Add(current);
            return result;
        }
        public static double FindMedianSortedArrays(int[] A, int[] B)
        {

            if (A.Length > B.Length) return FindMedianSortedArrays(B, A);

            int m = A.Length, n = B.Length;

            int totalLeft = (m + n + 1) / 2;

            int left = 0, right = m;

            while (left <= right)

            {

                int i = (left + right) / 2;

                int j = totalLeft - i;

                int Aleft = (i == 0) ? int.MinValue : A[i - 1];

                int Aright = (i == m) ? int.MaxValue : A[i];

                int Bleft = (j == 0) ? int.MinValue : B[j - 1];

                int Bright = (j == n) ? int.MaxValue : B[j];

                if (Aleft <= Bright && Bleft <= Aright)

                {

                    if ((m + n) % 2 == 1)

                        return Math.Max(Aleft, Bleft);

                    else

                        return (Math.Max(Aleft, Bleft) + Math.Min(Aright, Bright)) / 2.0;

                }

                else if (Aleft > Bright)

                {

                    right = i - 1;

                }

                else

                {

                    left = i + 1;

                }

            }

            throw new ArgumentException("Input arrays not valid");

        }

        public static int FindKthLargest(int[] nums, int k)
        {

            var pq = new PriorityQueue<int, int>(); // min-heap keyed by value

            foreach (var num in nums)

            {

                pq.Enqueue(num, num);

                if (pq.Count > k) pq.Dequeue();

            }

            return pq.Peek();

        }

        public static void Rotate(int[][] matrix)
        {

            int n = matrix.Length;

            // Transpose

            for (int i = 0; i < n; i++)

            {

                for (int j = i + 1; j < n; j++)

                {

                    var tmp = matrix[i][j];

                    matrix[i][j] = matrix[j][i];

                    matrix[j][i] = tmp;

                }

            }

            // Reverse each row

            for (int i = 0; i < n; i++)

            {

                Array.Reverse(matrix[i]);
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static bool HasCycle(ListNode head)

        {

            if (head == null) return false;

            var slow = head;

            var fast = head;

            while (fast?.next != null)

            {

                slow = slow.next;

                fast = fast.next.next;

                if (slow == fast) return true;

            }

            return false;

        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static string Serialize(TreeNode root)

        {

            if (root == null) return "";

            var sb = new StringBuilder();

            var q = new Queue<TreeNode?>();

            q.Enqueue(root);

            while (q.Count > 0)

            {

                var node = q.Dequeue();

                if (node == null) sb.Append("#,");

                else

                {

                    sb.Append(node.val).Append(',');

                    q.Enqueue(node.left);

                    q.Enqueue(node.right);

                }

            }

            return sb.ToString().TrimEnd(',');

        }

        public static TreeNode Deserialize(string data)

        {

            if (string.IsNullOrEmpty(data)) return null;

            var parts = data.Split(',', StringSplitOptions.RemoveEmptyEntries);

            var root = new TreeNode(int.Parse(parts[0]));

            var q = new Queue<TreeNode>();

            q.Enqueue(root);

            int i = 1;

            while (q.Count > 0 && i < parts.Length)

            {

                var node = q.Dequeue();

                var leftVal = parts[i++];

                if (leftVal != "#")

                {

                    node.left = new TreeNode(int.Parse(leftVal));

                    q.Enqueue(node.left);

                }

                if (i < parts.Length)

                {

                    var rightVal = parts[i++];

                    if (rightVal != "#")

                    {

                        node.right = new TreeNode(int.Parse(rightVal));

                        q.Enqueue(node.right);

                    }

                }

            }

            return root;

        }

    }

}
