// See https://aka.ms/new-console-template for more information
using Problems;
string input = Console.ReadLine();
//Console.WriteLine("Original String :"+input);
//Console.WriteLine("Reverse of the string using Reverse() method :"+string.Join("", input.Reverse()));
//Console.WriteLine("Reverse of the input string is :"+Class1.ReverseString(input));
//Console.WriteLine("Reverse of the inidividual workds of the sentence is :"+ Class1.ReverseIndividualWordsInASentence(input));
//Console.WriteLine("Extract letters in a sentence :"+Class1.ExtractLettersFromString(input));
//Console.WriteLine("Extract numbers in a sentence :"+Class1.ExtractNumbersFromString(input));
//Console.WriteLine("Check is the input is palindrome Class3: "+Class3.IsPalindrome(input));
//Console.WriteLine("Check is the input is palindrome Class2: "+Class2.IsPalindrome(input));
Console.WriteLine("Check is the input is palindrome Class3: "+Sample2.IsPalindromeRobust(input));

int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
//Console.WriteLine(Class1.FindMinMax(arr));
Console.WriteLine(Sample2.MaxSubArraySum(arr));
