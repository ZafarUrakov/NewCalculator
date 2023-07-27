namespace Calculator
{
    class Program
    {
        static void Main()
        {
            
            do
            {
                Console.WriteLine(@"
                Hi , what do you want to use ?:
                1. Calcualtor
                2. Multiplier");
                Console.Write("Your selection:");
                int teamSelection = Convert.ToInt32(Console.ReadLine()!);

                if(teamSelection == 1)
                {

                    Console.WriteLine("\t\tWELCOME TO UNIVERSAL CALCULATOR");
                    Console.WriteLine(@"
                    You have 5 actions:
                    <+> - addition
                    <-> - subtraction
                    <*> - multiplication
                    </> - division
                    <%> - remainder of the number");

                    Console.WriteLine("\nEnter the number to run the CALCULATOR.\n");
                    Console.Write("FirstNumber: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("\nSelect an action:\n");

                    Console.Write("Action: ");
                    char action = Convert.ToChar(Console.ReadLine()!);

                    Console.Write("\nSecondNumber: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nNumbers are being converted...\n");

                    double readyAnswer = action switch
                    {
                        '+' => firstNumber + secondNumber,
                        '-' => firstNumber - secondNumber,
                        '*' => firstNumber * secondNumber,
                        '/' => firstNumber / secondNumber,
                        '%' => firstNumber % secondNumber,
                        _ => 0
                    };
                    Console.WriteLine("Here are your result: ");
                    Console.WriteLine($"|{firstNumber} {action} {secondNumber} = "
                    +$"{readyAnswer}|");
                }
                else if(teamSelection == 2)
                {
                    Console.WriteLine("\t\tWELCOME TO MUTIPLICATION TABLE\n");

                    Console.Write("Enter a number to calculate:");
                    int numberToCalculate = Convert.ToInt32(Console.ReadLine()!);

                    for(int minorNumber = 1; minorNumber <= 9; minorNumber++)
                    {
                        int computedNumber = numberToCalculate;
                        computedNumber *= minorNumber;
                        Console.WriteLine($"{numberToCalculate} * {minorNumber} = {computedNumber}");
                    }

                }
            }
            while(true);
        }
    }
}