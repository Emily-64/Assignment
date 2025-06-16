// See https://aka.ms/new-console-template for more information
string b;
Console.Write("It is Raining (true or false) : ");
b = Console.ReadLine();

if (b == "true")
{
    Console.WriteLine("Take umbrella");
}
else if (b == "false")
{
    Console.WriteLine("No need of umbrella");
}
else
{
    Console.WriteLine("Invalid input, please enter true or false");
}
