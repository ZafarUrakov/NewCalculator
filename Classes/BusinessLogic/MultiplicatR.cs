using System.Runtime.InteropServices.JavaScript;

namespace Calculator.Classes;

public class MultiplicatR : IMultiplicatR
{
    IReportingContract reporter = new ReportR();
    private decimal number;
    private decimal loopVariable;

    public MultiplicatR()
    {
        number = ValueManipulatR.GetUserValueByMassage("Multiplication table\nNumber to calculate: ");
        MultiplyWork();
    }

    public void MultiplyWork()
    { 
        reporter.ResultProgress();
        for (int minorNumber = 1; minorNumber <= 9; minorNumber++)
        {
            loopVariable = number;
            loopVariable *= minorNumber;
            Console.WriteLine($"{number} * {minorNumber} = {loopVariable}");
        }
    }
}
