// See https://aka.ms/new-console-template for more information
long firstNumber = 0; 
long secondNumber = 0; ;

Console.WriteLine("enter two numbers : ");
firstNumber = Convert.ToInt64(Console.ReadLine());
secondNumber = Convert.ToInt64(Console.ReadLine());

try
{
    if (secondNumber == 0)
        throw new DivideByZeroException("Division by zero");
    else Console.WriteLine (firstNumber / secondNumber);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero!");
}
catch (Exception)
{
    Console.WriteLine("Unknown Exception");
}
finally
{
    Console.WriteLine("Calculation complete");
}
