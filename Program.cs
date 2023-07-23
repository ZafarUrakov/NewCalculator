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
    
            Console.Write("\nSecondNumber: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nNumbers are being converted...\n");

            Console.WriteLine($"Ready:\n");
            Console.WriteLine($"[{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}]");

            Console.WriteLine("\nConstact brother!");

        }
    }
}