namespace Calculator.Classes;

public interface IReportingContract
{ 
   int FormatExceptionMessage(); 
   void ResultProgress();
   void DefaultProgress();
   void Exit();
}