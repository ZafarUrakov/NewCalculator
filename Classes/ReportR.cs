namespace Calculator.Classes;

public class ReportR
{
    public static int FormatExceptionMessage()
    {

        int firstOption = 0;
        try
        {
            firstOption = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        catch (FormatException formatException)
        {
            Console.WriteLine("The input is not in a correct format");
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

    public static void ResultProgress()
    {
        Console.WriteLine("\nData progressing..");
    }

    public static void DefaultProgress()
    {
        Console.WriteLine("There is mo such choice, try again."); 
    }

    public static void Exit()
    {
        Console.WriteLine("Thanks for using the app..");
    }
}