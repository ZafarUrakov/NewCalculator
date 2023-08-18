namespace Calculator.Classes;

public class AdvancedCalculatR : CalculatR
{
    public AdvancedCalculatR(decimal firstNumberToCount, string function, decimal secondNumberToCount)
        : base(firstNumberToCount, function, secondNumberToCount)
    {
    }

    public decimal Prc(decimal firstNumberToCount, decimal secondNumberToCount)
    {
        decimal formula = (firstNumberToCount / 100) * secondNumberToCount;
        return formula;
    }

    public override void CalculatorWork()
    {
        decimal result = Prc(this.FirstNumberToCount, this.SecondNumberToCount);
        Console.WriteLine($"\nCalculate result: {this.SecondNumberToCount}% of {this.FirstNumberToCount} equals {result}.");
    }
}