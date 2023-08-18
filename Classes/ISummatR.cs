namespace Calculator.Classes;

public interface ISummatR
{
 decimal Sum(decimal firstNumberToCount, decimal secondNumberToCount);
 decimal Substract(decimal firstNumberToCount, decimal secondNumberToCount);
 decimal Multiply(decimal firstNumberToCount, decimal secondNumberToCount);
 decimal Divite(decimal firstNumberToCount, decimal secondNumberToCount);
 decimal CalculateRemainder(decimal firstNumberToCount, decimal secondNumberToCount);
}