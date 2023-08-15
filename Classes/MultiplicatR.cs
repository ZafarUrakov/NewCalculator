namespace Calculator.Classes;

public class MultiplicatR // business logic
{
    public string Greetings { get; set; }
    public decimal Convertion { get; set; }
    public decimal LoopVaruable { get; set; }

    public MultiplicatR()
    {
        this.Greetings = ValueManipulatR.GetInputByMessageToAction("Welcome to Multiplication table" + "\nEnter a numbet to calculate: ");
        this.Convertion = Convert.ToDecimal(this.Greetings);
        ShowMultiplicationTable();
    }
    public void ShowMultiplicationTable()
    {
        for(int minorNumber = 1; minorNumber <= 9; minorNumber++)
        {
            this.LoopVaruable = this.Convertion;
            this.LoopVaruable *= minorNumber;
            Console.WriteLine($"{this.Convertion} * {minorNumber} = {this.LoopVaruable}");
        }
    }
}