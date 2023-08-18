using System.Runtime.InteropServices.JavaScript;

namespace Calculator.Classes;

public class MultiplicatR// business logic
{
    public decimal Number { get; set; }
    public decimal LoopVariable { get; set; }

    public MultiplicatR()
    {
        Number = ValueManipulatR.GetUserValueByMassage("Multiplication table\nNumber to calculate: ");
        MultiplyWork();
    }

    private void MultiplyWork()
    { ReportR.ResultProgress();
        for (int minorNumber = 1; minorNumber <= 9; minorNumber++)
        {
            this.LoopVariable = this.Number;
            this.LoopVariable *= minorNumber;
            Console.WriteLine($"{this.Number} * {minorNumber} = {this.LoopVariable}");
        }
    }
}
