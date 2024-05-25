
Console.WriteLine("Enter first number:");
double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Enter 1-character action you want to perform:");
char action = char.Parse(Console.ReadLine());

Console.WriteLine("Enter first number:");
double secondNumber = double.Parse(Console.ReadLine());

double result = 0;
switch (action)
{
    case '+':
        result = firstNumber + secondNumber;
        break;
    case '-':
        result = firstNumber - secondNumber;
        break;
    case '*':
        result = firstNumber * secondNumber;
        break;
    case '/':
        if (secondNumber == 0)
        {
            Console.WriteLine("Warning: You can not divide by zero!");
        }
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("You entered incorrect action");
        break;
}

//if (action == '+')
//{
//    result = firstNumber + secondNumber;
//}
//else if (action == '-')
//{
//    result = firstNumber - secondNumber;
//}
//else if (action == '*')
//{
//    result = firstNumber * secondNumber;
//}
//else if (action == '/')
//{
//    if (secondNumber == 0)
//    {
//        Console.WriteLine("Warning: You can not divide by zero!");
//    }
//    result = firstNumber / secondNumber;
//}
//else
//{
//    Console.WriteLine("You entered incorrect action");
//}

bool isActionCorrect = action == '+' || action == '-' || action == '*' || action == '/';
if (result != double.PositiveInfinity && isActionCorrect)
{
    Console.WriteLine($"{firstNumber} {action} {secondNumber} = {result}");
}
else
{
    Console.WriteLine("Something went wrong!");
}

Console.ReadKey();