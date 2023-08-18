namespace Calculator.Classes;

public class ValueManipulatR // Broker - tashqa dan yoshiradi.
{
    public void ShowMenu()
    {
        Console.Write("MENU\n1.Calculator\n2.Multiplication table\n3.Exit\nChoice: ");
    }
    
    public static decimal GetUserValueByMassage(string text)
    {   decimal firstOption = 0;
        try
        {
            Console.Write(text);
            decimal number = decimal.Parse(Console.ReadLine()!);
        }
        catch (FormatException formatException)
        {
            Console.WriteLine("The input is not in a correct format");
            return 0;
        }
        catch (OverflowException overflowException)
        {
            Console.WriteLine("Value is too large or too small, take a look data type.");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
        return firstOption;
    }

    public static string GetInputByMessageToAction(string text)
    {
        Console.Write(text);
        return Console.ReadLine();
    }

    public static string AppLogin()
    {
        Console.Write("\nLaunch the application? yes or no\nChoice: ");
        string choice = Console.ReadLine()!;
        return choice;
    }
}