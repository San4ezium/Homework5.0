// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter numbers:");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine($"You entered a number: {number}");
}
else
{ 
    Console.WriteLine("Error: The entered value is not a number.");
}
