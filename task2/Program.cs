// See https://aka.ms/new-console-template for more information
Console.WriteLine("task2");
Console.Write("input a=");
double a = double.Parse(Console.ReadLine());
Console.Write("input b=");
double b = double.Parse(Console.ReadLine());



if (a>b)
    {
        Console.WriteLine("max = "+a);
    }
    else
    {
        Console.WriteLine("max = "+b);
    }
