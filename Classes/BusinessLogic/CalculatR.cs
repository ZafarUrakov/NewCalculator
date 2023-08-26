namespace Calculator.Classes;

public class CalculatR : ISummatR
{
    IReportingContract reporter = new ReportR();
    public decimal FirstNumberToCount { get; set; }
    public string Function { get; set; }
    public decimal SecondNumberToCount { get; set; }

    public CalculatR(decimal firstNumberToCount, string function, decimal secondNumberToCount)
    {
        FirstNumberToCount = firstNumberToCount;
        Function = function;
        SecondNumberToCount = secondNumberToCount;
        CalculatorWork();
    }

    protected virtual void CalculatorWork()// Polymorphism
    {
        reporter.ResultProgress();
        decimal result = this.Function switch
        {
            "+" => Sum(this.FirstNumberToCount, this.SecondNumberToCount),
            "-" => Substract(this.FirstNumberToCount, this.SecondNumberToCount),
            "*" => Multiply(this.FirstNumberToCount, this.SecondNumberToCount),
            "/" => Divite(this.FirstNumberToCount, this.SecondNumberToCount),
            "%" => CalculateRemainder(this.FirstNumberToCount, this.SecondNumberToCount),
            _ => 0
        };
        Console.WriteLine(
            $"\nCalculate result: {this.FirstNumberToCount} {this.Function} {this.SecondNumberToCount} = {result}");
    }

    public decimal Sum(decimal firstNumberToCount, decimal secondNumberToCount)
    {
        return firstNumberToCount + secondNumberToCount;
    }
    public decimal Substract(decimal firstNumberToCount, decimal secondNumberToCount)
    {
        return firstNumberToCount - secondNumberToCount;
    } 
    public decimal Multiply(decimal firstNumberToCount, decimal secondNumberToCount)
    {
        return firstNumberToCount * secondNumberToCount;
    }
    public decimal Divite(decimal firstNumberToCount, decimal secondNumberToCount)
    {
        return firstNumberToCount / secondNumberToCount;
    }
    public decimal CalculateRemainder(decimal firstNumberToCount, decimal secondNumberToCount)
    {
        return firstNumberToCount % secondNumberToCount;
    }
}