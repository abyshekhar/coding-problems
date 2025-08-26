using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    // This static class contains common C# problems with solutions and comments
    public static class Sample2
    {
        // ====================== STRING PROBLEMS ======================

        // Reverse a string
        // Problem: Given a string, return its reverse.
        // Example: Input: "hello", Output: "olleh"
        public static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Check if string is palindrome
        // Problem: Determine if a string reads the same backward as forward.
        // Example: Input: "racecar", Output: true
        public static bool IsPalindrome(string input)
        {
            string reversed = new string(input.Reverse().ToArray());
            return input == reversed;
        }

        public static bool IsPalindromeRobust(string input)
        {
            if (string.IsNullOrEmpty(input)) return true;

            int left = 0, right = input.Length - 1;
            while (left < right)
            {
                // Skip non-alphanumeric characters
                while (left < right && !char.IsLetterOrDigit(input[left])) left++;
                while (left < right && !char.IsLetterOrDigit(input[right])) right--;

                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                    return false;

                left++;
                right--;
            }
            return true;
        }


        // Remove certain characters from string
        // Problem: Remove specified characters from a string.
        // Example: Input: "hello", charsToRemove: ['l'], Output: "heo"
        public static string RemoveCharacters(string input, char[] charsToRemove)
        {
            return new string(input.Where(c => !charsToRemove.Contains(c)).ToArray());
        }

        // Convert char array to string
        // Problem: Convert a character array to a string.
        // Example: Input: ['h','i'], Output: "hi"
        public static string CharArrayToString(char[] chars)
        {
            return new string(chars);
        }

        // ====================== ARRAY PROBLEMS ======================

        // Find maximum element in an array
        public static int MaxElement(int[] arr) => arr.Max();

        // Reverse an array in-place
        public static void ReverseArray(int[] arr) => Array.Reverse(arr);

        // ====================== LINKED LIST PROBLEMS ======================

        public class Node
        {
            public int Data;
            public Node Next;
            public Node(int data) { Data = data; Next = null; }
        }

        public static Node Head = null;

        // Reverse a linked list
        // Problem: Reverse a singly linked list.
        // Example: 1->2->3 becomes 3->2->1
        public static void ReverseLinkedList()
        {
            Node prev = null, current = Head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
        }

        // Detect cycle in linked list
        // Problem: Return true if linked list contains a cycle.
        public static bool HasCycle(Node head)
        {
            Node slow = head, fast = head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast) return true;
            }
            return false;
        }

        // ====================== RECURSION PROBLEMS ======================

        // Factorial of a number using recursion
        // Example: Input: 5, Output: 120
        public static int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);

        // Fibonacci number using recursion
        // Example: Input: 5, Output: 5
        public static int Fibonacci(int n) => n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);

        // ====================== SORTING PROBLEMS ======================

        // Bubble sort
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Merge sort
        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return;
            int mid = arr.Length / 2;
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();
            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j]) arr[k++] = left[i++];
                else arr[k++] = right[j++];
            }
            while (i < left.Length) arr[k++] = left[i++];
            while (j < right.Length) arr[k++] = right[j++];
        }

        // ====================== STACK PROBLEMS ======================

        // Next greater element for each element in array using stack
        public static int[] NextGreaterElement(int[] arr)
        {
            int n = arr.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= arr[i]) stack.Pop();
                result[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(arr[i]);
            }
            return result;
        }

        // Check balanced parentheses
        public static bool IsBalancedParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(') stack.Push(c);
                else if (c == ')')
                {
                    if (stack.Count == 0) return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }

        // ====================== QUEUE USING STACKS ======================

        public class QueueUsingStacks
        {
            private Stack<int> stack1 = new Stack<int>();
            private Stack<int> stack2 = new Stack<int>();

            public void Enqueue(int x) => stack1.Push(x);

            public int Dequeue()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0) stack2.Push(stack1.Pop());
                }
                return stack2.Count > 0 ? stack2.Pop() : throw new InvalidOperationException("Queue is empty");
            }
        }

        // ====================== BINARY SEARCH TREE PROBLEMS ======================

        public class BSTNode
        {
            public int Data;
            public BSTNode Left, Right;
            public BSTNode(int data) { Data = data; Left = Right = null; }
        }

        public static BSTNode InsertBST(BSTNode root, int key)
        {
            if (root == null) return new BSTNode(key);
            if (key < root.Data) root.Left = InsertBST(root.Left, key);
            else root.Right = InsertBST(root.Right, key);
            return root;
        }

        public static void InOrderBST(BSTNode root)
        {
            if (root == null) return;
            InOrderBST(root.Left);
            Console.Write(root.Data + " ");
            InOrderBST(root.Right);
        }

        // ====================== DYNAMIC PROGRAMMING PROBLEMS ======================

        // Climbing stairs problem
        public static int ClimbStairs(int n)
        {
            if (n <= 2) return n;
            int a = 1, b = 2, temp = 0;
            for (int i = 3; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        // Coin change problem (minimum coins)
        public static int MinCoins(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            for (int i = 1; i <= amount; i++) dp[i] = max;
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (coin <= i) dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }

        // Problem: Reverse the words in a sentence.
        // Example: "Hello World" -> "World Hello"
        public static string ReverseWords(string sentence)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(' ', words);
        }
        // Problem: Find the contiguous subarray with the largest sum.
        // Example: [-2,1,-3,4,-1,2,1,-5,4] -> 6 (subarray [4,-1,2,1])
        public static int MaxSubArraySum(int[] arr)
        {
            int maxSoFar = arr[0], maxEndingHere = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }
        // Problem: Rotate an array to the right by k positions.
        // Example: [1,2,3,4,5], k=2 -> [4,5,1,2,3]
        public static void RotateArray(int[] arr, int k)
        {
            int n = arr.Length;
            k = k % n;
            Array.Reverse(arr);
            Array.Reverse(arr, 0, k);
            Array.Reverse(arr, k, n - k);
        }
        // Problem: Remove duplicate elements from an integer array.
        // Example: [1,2,2,3] -> [1,2,3]
        public static int[] RemoveDuplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }

    }
}
