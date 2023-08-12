using Calculator.Classes;

namespace Calculator
{
    class Program
    {
         static void Main()
        {
            int choiceOfOptions = 0;
            do
            {
                var calculator = new CalculatR();
                var multiplicator = new MultiplicatR();
                MessageR.ShowMenu();
                choiceOfOptions = MessageR.MessageErrors();
                if (choiceOfOptions == 1)
                    calculator.ShowCalculator();
                else if (choiceOfOptions == 2)
                    multiplicator.ShowMultiplicationTable();
                else if (choiceOfOptions == 3)
                {
                    MessageR.Exit();
                    break;
                }
            } while (choiceOfOptions != 4);
        }
    }
}