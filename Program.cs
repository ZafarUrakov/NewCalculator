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
                if (choiceOfOptions == 1)
                {
                    decimal firstValue = ValueManipulatR.GetUserValueByMassage("Welcome to Calculator" +
                                                                               "\n\tPRC - percentage counter" +
                                                                               "\nFirst number: ");
                    string actionValue = ValueManipulatR.GetInputByMessageToAction("\nOperation[+ | - | * | / | % | prc]: ");
                    if (actionValue == "prc")
                    {
                        decimal secondValue = ValueManipulatR.GetUserValueByMassage("\nPercent: ");
                        var calculate = new AdvancedCalculatR(firstValue, actionValue, secondValue);
                        calculate.ShowCalculator();
                    }
                    else if (actionValue == "+" || actionValue == "-" || actionValue == "*" || actionValue == "/" || actionValue == "%")
                    {
                        decimal secondValue = ValueManipulatR.GetUserValueByMassage("\nSecond number: ");
                        var calculator = new CalculatR(firstValue, actionValue, secondValue);
                    }
                    else
                        Console.WriteLine("There is no such choice.Try again.");

                }
                else if (choiceOfOptions == 2)
                {
                    var multiplicator = new MultiplicatR();
                }
                else if (choiceOfOptions == 3)
                {
                    ReportR.Exit();
                    break;
                }
                backToMenu = ValueManipulatR.BackToMenu();
            } while (backToMenu == "yes");
            Console.WriteLine("GoodBye!");
        }
    }
}