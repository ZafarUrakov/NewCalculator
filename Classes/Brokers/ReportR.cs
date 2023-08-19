namespace Calculator.Classes;

public class ReportR : IReportingContract
{
    public int FormatExceptionMessage()
    {

        int firstOption = 0;
        try
        {
            firstOption = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        catch (FormatException formatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input is not in a correct format");
            Console.ResetColor();
        }
        catch (OverflowException overflowException)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Value is too large or too small, take a look data type.");
            Console.ResetColor();

        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(exception.Message);
            Console.ResetColor();

        }

        return firstOption;
    }

    public void ResultProgress()
    {
        Console.WriteLine("\nData progressing..");
    }

    public void DefaultProgress()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("There is mo such choice, try again."); 
        Console.ResetColor();
    }

    public void Exit()
    {
        Console.WriteLine("Thanks for using the app..");
    }
}