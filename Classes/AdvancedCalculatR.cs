namespace Calculator.Classes;

public class AdvancedCalculatR : CalculatR
{
    public AdvancedCalculatR(decimal firstNumber, string option, decimal secondNumber)
        : base(firstNumber, option, secondNumber)
    {
    }

    public decimal Prc(decimal firstNunber, decimal secondNumber)
    {
        decimal formula = (firstNunber / 100) * secondNumber;
        return formula;
    }

    public override void ShowCalculator()
    {
        if (ActionValue == "prc")
        {
            decimal result = Prc(this.FirstValue, this.SecondValue);
            Console.WriteLine($"\nAnswer: {this.SecondValue}% of {this.FirstValue} = {result}.");
        }
        else
        {
            base.ShowCalculator();
        }
    }

}