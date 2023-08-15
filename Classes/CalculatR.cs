namespace Calculator.Classes;

public class CalculatR
{
    public decimal FirstValue { get; set; }
    public string ActionValue { get; set; }
    public decimal SecondValue { get; set; }

    public CalculatR(decimal firstValue, string actionValue, decimal secondValue)
    {
        FirstValue = firstValue;
        ActionValue = actionValue;
        SecondValue = secondValue;
        ShowCalculator();
    }
    public virtual void ShowCalculator()
    {
        ReportR.ReportProgress();
        decimal readyAnswer =  this.ActionValue switch
        {
            "+" => Sum(this.FirstValue, this.SecondValue),
            "-" => Substract(this.FirstValue, this.SecondValue),
            "*" => Multiply(this.FirstValue, this.SecondValue),
            "/" => Divite(this.FirstValue, this.SecondValue),
            "%" => CalculateRemainder(this.FirstValue, this.SecondValue),
            _ => 0
        };
        Console.WriteLine($"Here are your result: " +
                          $"{this.FirstValue} {this.ActionValue} {this.SecondValue} " +
                          $"= {readyAnswer}");
    }
    static decimal Sum(decimal firstNumber,decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }
        
    static decimal Substract(decimal firstNumber,decimal secondNumber)
    {
        return firstNumber - secondNumber;
    }

    static decimal Multiply(decimal firstNumber,decimal secondNumber)
    {
        return firstNumber * secondNumber;
    }

    static decimal Divite(decimal firstNumber,decimal secondNumber)
    {
        return firstNumber / secondNumber;
    }

    static decimal CalculateRemainder(decimal firstNumber,decimal secondNumber)
    {
        return firstNumber % secondNumber;
    }

    
}