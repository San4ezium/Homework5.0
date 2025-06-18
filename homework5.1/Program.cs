// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("enter two numbers : ");
    long firstNumber = Convert.ToInt64(Console.ReadLine());
    long secondNumber = Convert.ToInt64(Console.ReadLine());
    {
        if (secondNumber == 0)
            Console.WriteLine("Error: division by zero.");
            var result = firstNumber / secondNumber;
        Console.WriteLine($"Result division: {result} ");
    }
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
