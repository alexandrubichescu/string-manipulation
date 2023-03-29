using System;

namespace StringManipulation
{
    public class StringManipulator
    {
        public static string ToTitleCase(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1).ToLower();
            }
            string x= string.Join(" ", words);
            Console.Write("Camel Case string is: \"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(x);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"");
            return x;
        }

        public static void IsPalindrome(string input)
        {
            Console.Write("The string is:  \"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(input);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"");

            string[] words = input.Split(' ');
            int length = words.Length;
            Console.Write("There are ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(length);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" words in the string, choose a number from 1 to " + length + " to check if is palindrome:");
            int x = DataInput.GetIntFromUser(" ") - 1;
            char[] charArray = words[x].ToCharArray();
            Array.Reverse(charArray);
            string reversed = new(charArray);
            if (words[x].ToLower() == reversed.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("The word \"");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(words[x]);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\" is palindrome");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("The word \"");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(words[x]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\" is NOT palindrome");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void FindLongestAndShortestWords(string input)
        {
            string[] words = input.Split(' ');
            string longestWord = "";
            string shortestWord = input;
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }
            Console.Write("The longest word is: \"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(longestWord);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"");
            Console.Write("The shortest word is: \"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(shortestWord);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\""); 
        }

        public static void GetMostFrequentWord(string input)
        {
            string[] words = input.Split(' ');
            foreach(string word in words)
            {
                word.ToLower();
            }
     
            int[] wordFrequency = new int[words.Length];


            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        wordFrequency[i]++;
                    }
                }
            }

            int maxFrequencyIndex = 0;
            for (int i = 1; i < wordFrequency.Length; i++)
            {
                if (wordFrequency[i] > wordFrequency[maxFrequencyIndex])
                {
                    maxFrequencyIndex = i;
                }
            }

            Console.Write("The most frequent word in the string is: \"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(words[maxFrequencyIndex]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\" this repeats ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(wordFrequency[maxFrequencyIndex] + 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" times in the string");
        }

        public static string ReverseTheString(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            string str=string.Join(" ", words);
            Console.WriteLine("Reversed string is: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\""+str+"\"");
            Console.ForegroundColor = ConsoleColor.White;
            return str;
        }

        public static void CountNumberOfVowels(string input)
        {
            int vowelCount = 0;
            foreach (char c in input.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }
            Console.Write("There are ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(vowelCount);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" vowels in the string");
        }

        public static string ReplaceWords(string input)
        {
            Console.Write("The string is:  \"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(input);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"");
            string[] words = input.Split(' ');
            string initialWord = DataInput.GetStringFromUser("Enter the word you want to change(remember the words are case sensitive): ");
            string newWord = DataInput.GetStringFromUser("Enter the the new word: ");
            for (int i = 0;i<words.Length;i++)
            {
                if (words[i] == initialWord)
                {
                    words[i] = newWord; 
                }
            }
            string x = string.Join(" ", words);
            Console.Write("The new string resulted from word changing id: \"");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(x);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"");
            return x;
        }
    }
}
