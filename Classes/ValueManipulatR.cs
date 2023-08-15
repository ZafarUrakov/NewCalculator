namespace Calculator.Classes;

public class ValueManipulatR // Broker - tashqa dan yoshiradi.
{
    public static void ShowMenu()
    {
        Console.Write("\nWelcome.\n1.Calculator" +
                      "\n2.Multiplicator" +
                      "\n3.Exit" +
                      "\nChoice: ");
    }

    
    public static decimal GetUserValueByMassage(string massage)
    {
        Console.Write(massage);
        return decimal.Parse(Console.ReadLine());
    }
    public static string GetInputByMessageToAction(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
    
    
    static string CatchMassage(string CatchMassage)
    {
        Console.WriteLine(CatchMassage);
        return Console.ReadLine()!;
    }
    
    public static string BackToMenu()
    {
        Console.Write("\nBack to menu?[yes || no]\nChoice: ");
        string choice = Console.ReadLine();
        return choice;
    }

}