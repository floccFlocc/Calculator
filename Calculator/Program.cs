// See https://aka.ms/new-console-template for more information

double result = 0;


Console.WriteLine("Hello, This is a simple calculator for 2 numbers!\n\n");

Console.Write("Enter the first number: ");
if (!double.TryParse(Console.ReadLine(), out double number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.Write("Enter the second number: ");
if (!double.TryParse(Console.ReadLine(), out double number2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}


Console.WriteLine("Choose an operation (+, -, /, *)");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        result = number + number2;
        Console.WriteLine(number + operation + number2 + " = " + result);
        break;
    case "-":
        result = number - number2;
        Console.WriteLine(number + operation + number2 + " = " + result);
        break;
    case "*":
        result = number * number2;
        Console.WriteLine(number + operation + number2 + " = " + result);
        break;
    case "/":
        result = number / number2;
        Console.WriteLine(number + operation + number2 + " = " + result);
        break;
    default:
        Console.WriteLine("Invalid Operation");
        break;
}

