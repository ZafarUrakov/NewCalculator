namespace Calculator.Classes;

public class ReportR
{
    
    public static int ConvertInputOption()
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
    public static void ReportProgress()
    {
        Console.WriteLine("In progress...");
    }
    public static void Exit()
    {
        Console.WriteLine("Thank you for using our app.");
    }

}