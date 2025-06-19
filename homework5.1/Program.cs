// See https://aka.ms/new-console-template for more information

try
{
    Console.Write("Enter first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber / secondNumber; 
    Console.WriteLine($"Result division: {result} ");
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
