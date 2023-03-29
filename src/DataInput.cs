
namespace StringManipulation;

public static class DataInput
{
    public static string GetStringFromUser(string prompt)
    {
        Console.Write(prompt);
        Console.ForegroundColor= ConsoleColor.Cyan;
         string? str = Console.ReadLine();

        if (string.IsNullOrEmpty(str))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a non-empty string!");
            Console.ForegroundColor = ConsoleColor.White;
            return GetStringFromUser(prompt);
        }
        Console.ForegroundColor = ConsoleColor.White;

        return str;
    }
        
    public static int GetIntFromUser(string prompt)
    {
        int userInput;
        Console.Write(prompt);
        try
        {
            userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
        catch (Exception ex) when (ex.Message != "!")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid input. Please enter an integer");
            Console.ForegroundColor = ConsoleColor.White;
            return GetIntFromUser(prompt);

        }
    }
}

