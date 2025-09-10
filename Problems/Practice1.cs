using System.Text;

namespace Problems
{
    public static class Practice1
    {
        public static string ReverseString(string input)
        {
            if (input == null) throw new ArgumentNullException($"{nameof(input)} cannot ne null");

            if (input == string.Empty) return input;

            char[] output = new char[input.Length];
            int j = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output[j] = input[i];
                j++;
            }
            return new string(output);
        }

        public static string ReverseIndividualWordsInASentence(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            if (input == string.Empty) return input;
            string[] words = input.Split(" ");
            string[] reverseWords = new string[words.Length];
            for (int i = 0; i <= words.Length - 1; i++)
            {
                char[] reverse = new char[words[i].Length];
                //Reverse each word
                int k = 0;
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    reverse[k] = words[i][j];
                    k++;
                }
                reverseWords[i] = new string(reverse);
            }
            return string.Join(" ", reverseWords);
        }

        public static string ReverseTheSentenceByWords(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            //Split the sentence into words
            string[] words = input.Split(" ");
            string[] reversedWords = new string[words.Length];
            //Reverse the words in the sentence
            int j = 0;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedWords[j] = words[i];
                j++;
            }
            return string.Join(" ", reversedWords);
        }
        public static string ExtractLettersFromString(string input)
        {
            char[] chars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                chars = input.Where(char.IsLetter).ToArray();
            }
            return new string(chars);
        }
        public static string ExtractNumbersFromString(string input)
        {
            return new string(input.Where(char.IsNumber).ToArray());
        }
        public static string ReverseArray(int[] ints)
        {
            int[] reversedInts = new int[ints.Length];
            int j = 0;
            for (int i = ints.Length - 1; i >= 0; i--)
            {
                reversedInts[j] = ints[i];
                j++;
            }
            return string.Join(",", reversedInts);
        }

        public static (int, int) FindMinMax(int[] ints)
        {
            int min = ints[0];
            int max = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                min = ints[i] < min ? ints[i] : min;
                max = ints[i] > max ? ints[i] : max;
            }
            return (min, max);
        }
        public static (int, int) CountVowelsConsonants(string input)
        {
            int CountOfVowels = 0;
            int CountOfConsonants = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiou".Contains(input[i])) CountOfVowels++; else CountOfConsonants++;
            }
            return (CountOfVowels, CountOfConsonants);
        }

        public static void FrequencyOfLettersOfString(string input)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char inputCharacter = char.ToLower(input[i]);
                if (frequency.ContainsKey(inputCharacter))
                {
                    frequency[inputCharacter]++;
                }
                else frequency[inputCharacter] = 1;
            }
            foreach (var item in frequency)
            {
                System.Console.WriteLine($"Frequency of {item.Key} is " + frequency[item.Key]);
            }
        }
        public static bool IsPalindrome(string input)
        {
            int i = 0, j = input.Length - 1;
            while (i < j)
            {
                if (input[i] != input[j]) return false;
                i++;
                j--;
            }
            return true;
        }

        public static bool IsPalindromeRobust(string input)
        {
            int left = 0, right = input.Length - 1;
            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(input[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(input[right]))
                {
                    right--;
                }
                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        // Sudhanshu
        public static int LongestUniqueSubstring(string input)
        {
            HashSet<char> values = new HashSet<char>();
            for (int left = 0; left < input.Length; left++)
            {
                int right = 0;
                while (values.Contains(input[left]))
                {
                    values.Remove(input[right]);
                    right++;
                }
                values.Add(input[left]);

            }
            return 0;
        }

        public static string ReverseWordsWithoutSplit(string input)
        {
            int start = 0;
            bool wordEnd = false;
            List<string> words = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    wordEnd = true;
                    words.Add(input.Substring(start, i - start));

                }

                if (wordEnd) { start = i; wordEnd = false; }
            }
            words.Add(input.Substring(start, input.Length - start));
            List<string> reverseWords = new List<string>();
            words.ForEach(word => reverseWords.Add(new string(word.Trim().Reverse().ToArray())));
            string output = string.Join(' ', reverseWords);

            Console.WriteLine(output);
            return string.Empty;
        }
        //aabbbccc
        public static string CompressString(string input)
        {
            // Handle empty or null input
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder compressedString = new StringBuilder();
            int frequency = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    frequency++;
                }
                else
                {
                    compressedString.Append(input[i - 1]);
                    compressedString.Append(frequency);
                    frequency = 1;
                }
            }

            compressedString.Append(input[input.Length - 1]);
            compressedString.Append(frequency);

            // Check if the compressed string is actually smaller
            if (compressedString.Length < input.Length)
            {
                return compressedString.ToString();
            }
            else
            {
                return input;
            }
        }

    }

}