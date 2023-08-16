using Calculator.Classes;

namespace Calculator
{
    class Program // Exposer - tahtim kiluvchi qavat
    {
         static void Main()
         { string backToMenu;
            do
            {
                ValueManipulatR.ShowMenu();
                int choiceOfOptions = ReportR.ConvertInputOption();
                switch (choiceOfOptions)
                {
                    case 1:
                        decimal firstValue = ValueManipulatR.GetUserValueByMassage("Welcome to Calculator" +
                            "\n\tPRC - percentage counter" +
                            "\nFirst number: ");
                        string actionValue = ValueManipulatR.GetInputByMessageToAction("\nOperation[+ | - | * | / | % | prc]: ");
                        if (actionValue == "prc")
                        {
                            decimal secondValue = ValueManipulatR.GetUserValueByMassage("\nPercent: ");
                            var calculate = new AdvancedCalculatR(firstValue, actionValue, secondValue);
                            // calculate.ShowCalculator(); - fixed the errors, the reason was the constructor + additional output to the console.
                        }
                        else
                        {
                            decimal secondValue = ValueManipulatR.GetUserValueByMassage("\nSecond number: ");
                            var calculator = new CalculatR(firstValue, actionValue, secondValue);
                        }
                        break;
                    case 2:
                    {
                        var multiplicator = new MultiplicatR();break;
                    }
                    case 3:
                        {
                            ReportR.Exit();
                            break;
                        }
                }
                backToMenu = ValueManipulatR.BackToMenu();
            } while (backToMenu == "yes");
            Console.WriteLine("GoodBye!");
        }
    }
}