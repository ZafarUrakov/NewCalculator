using Calculator.Classes;

namespace Calculator
{
    class Program // Exposer - tahtim kiluvchi qavat
    {
         static void Main()
         {
             string backToMenu;
             do
             {
                 Console.Clear();
                 IReportingContract reporter = new ReportR();
                 ValueManipulatR.ShowMenu();
                 int itemSelection = reporter.FormatExceptionMessage();
                 switch (itemSelection)
                 {
                     case 1:
                         decimal firstNumberToCount =
                             ValueManipulatR.GetUserValueByMassage("Calculator\nFirst number: ");
                         string function =
                             ValueManipulatR.GetInputByMessageToAction("\n[+, -, *, /, %, prc] Function: ");
                         if (function == "prc")
                         {
                             decimal secondNumberToCount = ValueManipulatR.GetUserValueByMassage("\nPercent: ");
                             var advancedCalculator =
                                 new AdvancedCalculatR(firstNumberToCount, function, secondNumberToCount);
                         }
                         else
                         {
                             decimal secondNumberToCount = ValueManipulatR.GetUserValueByMassage("\nSecond number: ");
                             ISummatR calculator =
                                 new CalculatR(firstNumberToCount, function, secondNumberToCount);
                         } 
                         break;
                     case 2:
                         var multiplicatR = new MultiplicatR(); break;
                     case 3:
                         reporter.Exit(); break;
                     default: reporter.DefaultProgress(); break;
                 }
                 backToMenu = ValueManipulatR.AppLogin();
             } while (backToMenu == "yes");
         }
    }
}