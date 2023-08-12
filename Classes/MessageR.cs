namespace Calculator.Classes;

public static class MessageR
{
    public static void ShowMenu()
    {
        Console.Write(@"
                    Welcome!
                    1.Calculator
                    2.Multiplication
                    3.Exit
                    Choice: ");
    }

    static string CatchMassage(string CatchMassage)
    {
        Console.WriteLine(CatchMassage);
        return Console.ReadLine()!;
    }

    public static void Exit()
    {
        Console.WriteLine("Thank you for using our app.");
    }
    
    public static string GetUserValueByMassage(string massage)
    {
        Console.Write(massage);
        return Console.ReadLine()!;
    }

    public static int MessageErrors()
    {
        int choiceOfOptions = 0;
        try
        {
            choiceOfOptions = int.Parse(Console.ReadLine()!);
        }
        catch (FormatException formatexception)
        {
            CatchMassage("\nTry again bro!");
        }
        catch (OverflowException overFlowException)
        {
            CatchMassage("\nValue you provided was either too large or too small.\n");
        }
        catch (Exception exception)
        {
            CatchMassage("\nOops, something went wrong, contact support.\n");
        }
        return choiceOfOptions;
    }
}