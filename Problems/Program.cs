// See https://aka.ms/new-console-template for more information
using Problems;
Console.WriteLine("Welcome to the world of Coding Problems!");
string input = Console.ReadLine();
//Console.WriteLine("Original String :"+input);
//Console.WriteLine("Reverse of the string using Reverse() method :"+string.Join("", input.Reverse()));
//Console.WriteLine("Reverse of the input string is :"+Class1.ReverseString(input));
//Console.WriteLine("Reverse of the inidividual workds of the sentence is :"+ Class1.ReverseIndividualWordsInASentence(input));
//Console.WriteLine("Extract letters in a sentence :"+Class1.ExtractLettersFromString(input));
//Console.WriteLine("Extract numbers in a sentence :"+Class1.ExtractNumbersFromString(input));
//Console.WriteLine("Check is the input is palindrome Class3: "+Class3.IsPalindrome(input));
//Console.WriteLine("Check is the input is palindrome Class2: "+Class2.IsPalindrome(input));
//Console.WriteLine("Check is the input is palindrome Class3: "+Sample2.IsPalindromeRobust(input));

//int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
//Console.WriteLine(Class1.FindMinMax(arr));
//Console.WriteLine(Sample2.MaxSubArraySum(arr));
System.Console.WriteLine(Practice1.ReverseString(input));
System.Console.WriteLine(Practice1.ReverseIndividualWordsInASentence(input));
System.Console.WriteLine(Practice1.ReverseTheSentenceByWords(input));
System.Console.WriteLine(Practice1.ExtractLettersFromString(input));
System.Console.WriteLine(Practice1.ExtractNumbersFromString(input));

System.Console.WriteLine(Practice1.ReverseArray((new int[]  {1,2,3,4,5, 6, 7 })));
System.Console.WriteLine(Practice1.FindMinMax((new int[] { 1, 2, 3, 4, 5, 6,7})));
System.Console.WriteLine(Practice1.CountVowelsConsonants(input));
Practice1.FrequencyOfLettersOfString(input);