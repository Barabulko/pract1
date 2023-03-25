// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("input a=");
double a = double.Parse(Console.ReadLine());

if (a%2==0)
{
    Console.WriteLine("even (да)");
}
else
{
    Console.WriteLine("odd (нет)");
}