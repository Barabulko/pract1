// See https://aka.ms/new-console-template for more information
Console.WriteLine("task4");
Console.Write("input a=");
double a = double.Parse(Console.ReadLine());
Console.Write("input b=");
double b = double.Parse(Console.ReadLine());
Console.Write("input c=");
double c = double.Parse(Console.ReadLine());

if (a>b)
{
    if (a>c)
    {
        Console.WriteLine("max = "+a);
    }
}
if (b>a)
{
    if (b>c)
    {
        Console.WriteLine("max = "+b);
    }
}
if (c>a)
{
    if (c>b)
    {
        Console.WriteLine("max = "+c);
    }
}