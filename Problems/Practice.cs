using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public static class Practice
    {
        public static string ReverseString(string str)
        {
            if (str == null) { return string.Empty; }
            // key point is the creation of the string from the constructor by taking an array of characters
            string reverse = new string(str.Reverse().ToArray());
            return reverse;
        }

        public static bool IsPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }

        public static bool IsPalindromeRobust(string str)
        {
            if(string.IsNullOrEmpty(str)) { return false; }
            for(int i = 0;i<= str.Length;i++)
            {
                int left = 0, right = str.Length - 1;
                while (left < right && !char.IsLetterOrDigit(str[left])) left++;
                while (left < right && char.IsLetterOrDigit(str[right])) right--;

                if (str[left] != str[right]) return false;
            }
            
            return true;
        }
    }
}
