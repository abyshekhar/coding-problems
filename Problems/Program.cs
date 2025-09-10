// See https://aka.ms/new-console-template for more information
using Problems;
//Console.WriteLine("Welcome to the world of Coding Problems!");
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
//System.Console.WriteLine(Practice1.ReverseString(input));
//System.Console.WriteLine(Practice1.ReverseIndividualWordsInASentence(input));
//System.Console.WriteLine(Practice1.ReverseTheSentenceByWords(input));
//System.Console.WriteLine(Practice1.ExtractLettersFromString(input));
//System.Console.WriteLine(Practice1.ExtractNumbersFromString(input));

//System.Console.WriteLine(Practice1.ReverseArray((new int[]  {1,2,3,4,5, 6, 7 })));
//System.Console.WriteLine(Practice1.FindMinMax((new int[] { 1, 2, 3, 4, 5, 6,7})));
//System.Console.WriteLine(Practice1.CountVowelsConsonants(input));
//Practice1.FrequencyOfLettersOfString(input);
//Console.WriteLine($"Is Palindrome: "+Practice1.IsPalindrome(input));
//Console.WriteLine($"Is Palindrome Robust: "+Practice1.IsPalindromeRobust(input));
//Console.WriteLine(  Sample1.LongestUniqueSubstring(input));
//List<int> ints = Practice1.IndexesAnagramInAString("cbaebabacd", "abc");
//ints.ForEach(i => Console.WriteLine(i));
//IList<int> ints1 = Sample1.FindAnagrams("cbaebabacd", "abc");
//ints1.ToList().ForEach(i => Console.WriteLine(i));
//List<int[]> ints = [[1, 2], [3, 4], [1, 5], [6, 7]];
//Console.WriteLine("Original List of Arrays:");
//foreach (var arr in ints)
//{
//    // Print the actual contents of each array
//    Console.WriteLine($"[{string.Join(", ", arr)}]");
//}
//IList<int[]> mergedArray = Sample1.MergeIntervals(ints);
//Console.WriteLine("Merged List of Arrays:");
//foreach (var arr in mergedArray)
//{
//    // Print the actual contents of each merged array
//    Console.WriteLine($"[{string.Join(", ", arr)}]");
//}

Practice1.ReverseWordsWithoutSplit(input);

// SortedDictionary
//SortedDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>();
//keyValuePairs.Add(10, 2);
//keyValuePairs.Add(2, 3);
//keyValuePairs.Add(3, 4);
//keyValuePairs.Add(12, 5);
//foreach (var item in keyValuePairs)
//{
//    Console.WriteLine($"SortedDictionary - Key:{item.Key} Value:{item.Value}");
//}
//Console.WriteLine($"Accessing the value by key that exists: {keyValuePairs[3]}");
//try
//{
//    Console.WriteLine($"Accessing the value by key that does not exists: {keyValuePairs[11]}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//SortedList<int,int> sortedList = new SortedList<int,int>();
//sortedList.Add(10, 2);
//sortedList.Add(2, 3);
//sortedList.Add(3, 4);
//sortedList.Add(12, 5);
//foreach (var item in sortedList)
//{
//    Console.WriteLine($"SortedList - Key:{item.Key} Value:{item.Value}");
//}

//Console.WriteLine($"Accessing the value by index that exists: {sortedList[3]}");
//try
//{
//    Console.WriteLine($"Accessing the value by index that does not exists: {sortedList[11]}");
//}
//catch(IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("The index does not exists in the list");
//}
//SortedSet<int> sortedSet = new SortedSet<int>();
//sortedSet.Add(10);
//sortedSet.Add(2);
//sortedSet.Add(3);
//sortedSet.Add(12);
//foreach (var item in sortedSet)
//{
//    Console.WriteLine($"SortedSet - {item}");
//}

//List<Employee> employees = new List<Employee> { new Employee { Id=10,Name="John"},new Employee { Id=1,Name="Doe"} };
//employees.Sort();
//foreach (Employee employee in employees) Console.WriteLine($"{employee.Id} - {employee.Name}");
Console.WriteLine(Practice1.CompressString(input));
