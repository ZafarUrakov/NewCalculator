namespace Calculator.Classes;

public class ValueManipulatR // Broker
{
    private string text;
    public void ShowMenu()
    {
        Console.Write("MENU\n1.Calculator\n2.Multiplication table\n3.Exit\nChoice: ");
    }

    public static decimal GetUserValueByMassage(string text)
    {
        Console.Write(text);
            return decimal.Parse(Console.ReadLine()!);
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