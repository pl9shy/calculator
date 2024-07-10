Console.Write("Введите первое число: ");
string firstNum = Console.ReadLine();

Console.Write("Введите второе число: ");
string secondNum = Console.ReadLine();

Console.Write($"Какую операцию выполнить?\n+\t-\t*\t/");
string Symbol = Console.ReadLine();

if (Symbol == "+")
{
    int result = int.Parse(firstNum) + int.Parse(secondNum);
    Console.WriteLine($"{firstNum} + {secondNum} = {result}");
}
if (Symbol == "-")
{
    int result = int.Parse(firstNum) - int.Parse(secondNum);
    Console.WriteLine($"{firstNum} - {secondNum} = {result}");
}
if (Symbol == "*")
{
    int result = int.Parse(firstNum) * int.Parse(secondNum);
    Console.WriteLine($"{firstNum} * {secondNum} = {result}");
}
if (Symbol == "/")
{
    int result = int.Parse(firstNum) / int.Parse(secondNum);
    Console.WriteLine($"{firstNum} : {secondNum} = {result}");
}
Console.ReadLine();