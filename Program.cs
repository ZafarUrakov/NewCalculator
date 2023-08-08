namespace Calculator
{
    class Program
    {
        static void Main()
        {
            start:
            try
            {
                FullSet();
                goto start;
            }
            catch(FormatException formatexception)
            {
                CatchMassage("\n\t\t\tTry again bro!");
                goto start;
            }
            catch(OverflowException overFlowException)
            {
                CatchMassage("\nValue you provided was either too large or too small.\n");
                goto start;
            }
            catch(Exception exception)
            {
                CatchMassage("\nOops, something went wrong, contact support.\n");
            }
        }
        static void FullSet()
        {
            string pass = GetUserValueByMassage(@"
                    1.Entrance
                    2.Exit
                    Choice: ");
            double passNumber = Convert.ToDouble(pass);
                
            while(passNumber == 1)
                {
                    string teamSelection = GetUserValueByMassage(@"
                        Hi , what do you want to use ?:
                        1. Calcualtor
                        2. Multiplier
                        Your selection: ");
                    double teamSelectionToConvert = Convert.ToDouble(teamSelection);
                    if(teamSelectionToConvert == 1)
                    {
                        ShowCalculator();
                    } 
                        
                    else if(teamSelectionToConvert == 2)
                    {
                        ShowMultiplicationTable();
                        
                    } 
                }

            Console.WriteLine("\nGoodBye!");
        }

        static void ShowMultiplicationTable()
        {
            string numberToCalculate = GetUserValueByMassage(@"
                    WELCOME TO MUTIPLICATION TABLE
                    Enter a number to calculate: ");
            int numberToConvert = Convert.ToInt32(numberToCalculate);

            for(int minorNumber = 1; minorNumber <= 9; minorNumber++)
            {
            int computedNumber = numberToConvert;
            computedNumber *= minorNumber;
            Console.WriteLine($"\t\t\t{numberToConvert} * {minorNumber} = {computedNumber}");
            }
        
        }
        
        static void ShowCalculator()
        {
             string firstNumber = GetUserValueByMassage(@"
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
                    
                        string action = GetUserValueByMassage(@"
                    Select an action:
                    Action: ");
                        char actionToConvert = Convert.ToChar(action);


                        string secondNumber = GetUserValueByMassage(@"
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
                        string enter = GetUserValueByMassage(@$"
                    Here are your result: {firstNumber} {action} {secondNumber} = {readyAnswer}
                    Enter..");
                        
                        int enterToConvert = Convert.ToInt32(enter);
                        
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

        static string GetUserValueByMassage(string massage)
        {
            Console.Write(massage);
            return Console.ReadLine()!;
        }

        static string CatchMassage(string CatchMassage)
        {
            Console.WriteLine(CatchMassage);
            return Console.ReadLine()!;
        }

    }
}