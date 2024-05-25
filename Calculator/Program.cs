// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number:");
double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Enter 1-character action you want to perform:");
char action = char.Parse(Console.ReadLine());

Console.WriteLine("Enter first number:");
double secondNumber = double.Parse(Console.ReadLine());

double result = 0;
if (action == '+')
{
    result = firstNumber + secondNumber;
}
else if (action == '-')
{
    result = firstNumber - secondNumber;
}
else if (action == '*')
{
    result = firstNumber * secondNumber;
}
else if (action == '/')
{
    if (secondNumber == 0)
    {
        Console.WriteLine("Warning: You can not divide by zero!");
    }
    result = firstNumber / secondNumber;
}

Console.WriteLine($"{firstNumber} {action} {secondNumber} = {result}");
Console.ReadKey();