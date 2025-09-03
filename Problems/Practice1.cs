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
                System.Console.WriteLine($"Frequency of {item.Key} is "+ frequency[item.Key]);
            }
        }
    }

}