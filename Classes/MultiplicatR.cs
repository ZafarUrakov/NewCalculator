namespace Calculator.Classes;

public class MultiplicatR
{
    public void ShowMultiplicationTable()
    {
        string numberToCalculate = MessageR.GetUserValueByMassage(@"
                    WELCOME TO MUTIPLICATION TABLE
                    Enter a number to calculate: ");
        int numberToConvert = Convert.ToInt32(numberToCalculate);

        for(int minorNumber = 1; minorNumber <= 9; minorNumber++)
        {
            int computedNumber = numberToConvert;
            computedNumber *= minorNumber;
            Console.WriteLine($"\t\t\t{numberToConvert} * {minorNumber} = {computedNumber}");
        }
    }
}