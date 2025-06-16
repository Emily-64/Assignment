// See https://aka.ms/new-console-template for more information
double i, j, res;
string oper;

Console.Write("Value 1 : ");

i = double.Parse(Console.ReadLine());

Console.Write("Value 2 : ");

j = double.Parse(Console.ReadLine());

Console.WriteLine("Choose an operator (+ or - or * or /)");
oper = Console.ReadLine();

if (oper == "+")
{
    res = i + j;
}
else if (oper == "-")
{
    res = i - j;
}
else if (oper == "*")
{
    res = i * j;
}
else if (oper == "/")
{
    res = i / j;
}
else
{
    Console.WriteLine("I don't know");
    return;
}
Console.WriteLine(res);
