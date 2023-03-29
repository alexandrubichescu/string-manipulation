namespace StringManipulation;

public class Menu
{
    public static void EntryMenu()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\t\t\t\tWelcome to String Fun Adventures!");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t---------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("Get ready to explore the world of strings and discover all the fun you can have with them!");
        Console.WriteLine();
        Console.WriteLine("Your mission, if you choose to accept it, is to navigate through various challenges along the way.");
        Console.WriteLine();
        Console.WriteLine("You'll be able to enter a string of your choice and then transform it in ways you never thought possible!");
        Console.WriteLine();
        Console.WriteLine("Are you ready to take on the challenge?");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t\t\tPress any key to accept the mission...");
        Console.ReadKey(true);
    }
    public static void BasicMenu()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n\nPlease select an option:");
        Console.WriteLine("1. Convert the string to uppercase");
        Console.WriteLine("2. See the reverse string");
        Console.WriteLine("3. Count the number of vowels in the string");
        Console.WriteLine("4. Count the number of words in the string");
        Console.WriteLine("5. Convert the string to title case");
        Console.WriteLine("6. Check if a word from the string is a palindrome");
        Console.WriteLine("7. Find the longest and shortest words in the string");
        Console.WriteLine("8. Find the most frequent word in the string");
        Console.WriteLine("9. Replace words");
        Console.WriteLine("0. Exit");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void MainMenu()
    {
         EntryMenu();
         bool exit = false;
         string? input = DataInput.GetStringFromUser("Enter the string: ");
         while (exit==false)
         {
            BasicMenu();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int choice = DataInput.GetIntFromUser("Enter your choice: ");
            Console.ForegroundColor = ConsoleColor.White;

            switch (choice)
            {
                case 1:
                    Console.Write("The uppercase string is: ");
                    Console.ForegroundColor=ConsoleColor.Cyan;
                    input=input.ToUpper();
                    Console.WriteLine(input);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case 2:
                    StringManipulator.ReverseTheString(input);
                    break;

                case 3:
                    StringManipulator.CountNumberOfVowels(input);
                    break;

                case 4:
                    string[] numberOfWords = input.Split(' ');
                    Console.Write("There are ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(numberOfWords.Length);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" words in the string");
                    break;

                case 5:
                    input=StringManipulator.ToTitleCase(input);
                    break;

                case 6:
                    StringManipulator.IsPalindrome(input);
                    break;

                case 7:
                    StringManipulator.FindLongestAndShortestWords(input);
                    break;

                case 8:
                    StringManipulator.GetMostFrequentWord(input);
                    break;

                case 9:
                    input=StringManipulator.ReplaceWords(input);
                    break;

                case 0:
                    exit= true;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\n\t\t\t\tBye Bye!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong entry");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
         }
    }
}

