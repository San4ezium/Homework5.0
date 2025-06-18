// See https://aka.ms/new-console-template for more information

Console.Write("Enter numbers: ");
string input = Console.ReadLine();

try
{
    int number = Convert.ToInt32(input);
    Console.WriteLine($"You entered a number: {number}");
}
catch (FormatException)
{
    Console.WriteLine("Error: The entered value is not a number.");
}