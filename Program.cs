namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\t\t\tUNIVERSAL CALCULATOR");
            Console.WriteLine(@"
                        You have 5 actions:
                        [+] - addition
                            [-] - subtraction
                        [*] - multiplication
                            [/] - division
                        [%] - remainder of the number");

            Console.WriteLine("\nEnter the number to run the CALCULATOR.\n");
            Console.Write("FirstNumber: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\nSelect an action:\n");

            Console.Write("Action: ");
            char action = Convert.ToChar(Console.ReadLine()!);

            Console.Write("\nSecondNumber: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nNumbers are being converted...\n");

            decimal firstNumberConvert = Convert.ToDecimal(firstNumber);
            decimal secondNumberConvert = Convert.ToDecimal(secondNumber);

            if(action == '+')
                Console.WriteLine(@$"Here are your result:
                [{firstNumberConvert} + {secondNumberConvert} = "
                +$"{firstNumberConvert + secondNumberConvert}]");
            else if(action == '-')
                Console.WriteLine(@$"Here are your result:
                [{firstNumberConvert} - {secondNumberConvert} = "
                + $"{firstNumberConvert - secondNumberConvert}]");
            else if(action == '*')
                Console.WriteLine(@$"Here are your result:
                [{firstNumberConvert} * {secondNumberConvert} = " 
                + $"{firstNumberConvert * secondNumberConvert}]");
            else if(action == '/')
                Console.WriteLine(@$"Here are your result:
                [{firstNumberConvert} / {secondNumberConvert} = "
                + $"{firstNumberConvert / secondNumberConvert}]");
            else if(action == '%')
                Console.WriteLine(@$"Here are your result:
                [{firstNumberConvert} % {secondNumberConvert} = "
                + $"{firstNumberConvert % secondNumberConvert}]");
            else 
                Console.WriteLine("There is no such choice , try again by entering \"dotnet run\" !");
        }
    }
}