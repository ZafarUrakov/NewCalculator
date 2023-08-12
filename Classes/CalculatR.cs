namespace Calculator.Classes;

public class CalculatR
{
    public void ShowCalculator()
    {
        string firstNumber = MessageR.GetUserValueByMassage(@"
                    WELCOME TO UNIVERSAL CALCULATOR
                    You have 5 actions:
                    <+> - addition
                    <-> - subtraction
                    <*> - multiplication
                    </> - division
                    <%> - remainder of the number
                    Enter the number to run the CALCULATOR.
                    FirstNumber: ");
        double firstNumberToConvert = Convert.ToDouble(firstNumber);

        string action = MessageR.GetUserValueByMassage(@"
                    Select an action:
                    Action: ");
        char actionToConvert = Convert.ToChar(action);


        string secondNumber = MessageR.GetUserValueByMassage(@"
                    SecondNumber: ");
        double secondNumberToConvert = Convert.ToDouble(secondNumber);

        Console.WriteLine(@"
                    Numbers are being converted...");

        double readyAnswer = actionToConvert switch
        {
            '+' => Sum(firstNumberToConvert, secondNumberToConvert),
            '-' => Substract(firstNumberToConvert, secondNumberToConvert),
            '*' => Multiply(firstNumberToConvert, secondNumberToConvert),
            '/' => Divite(firstNumberToConvert, secondNumberToConvert),
            '%' => CalculateRemainder(firstNumberToConvert, secondNumberToConvert),
            _ => 0
        };
        Console.WriteLine(@$"
                    Here are your result: {firstNumber} {action} {secondNumber} = {readyAnswer}");
    }
    static double Sum(double firstNumber,double secondNumber)
    {
        return firstNumber + secondNumber;
    }
        
    static double Substract(double firstNumber,double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    static double Multiply(double firstNumber,double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    static double Divite(double firstNumber,double secondNumber)
    {
        return firstNumber / secondNumber;
    }

    static double CalculateRemainder(double firstNumber,double secondNumber)
    {
        return firstNumber % secondNumber;
    }

    
}