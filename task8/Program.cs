// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("input a=");
int a = int.Parse(Console.ReadLine());
int i = 2;
while (i<=a)
{
    if (i%2==0){
        Console.Write(i+", ");
    }
    i++;
}