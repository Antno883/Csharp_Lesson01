using System;
Console.Clear();
Console.Write("Input value 1 = ");
int number=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Input value 2 = ");
int number2=int.Parse(Console.ReadLine());
int sqr=number2*number2;

// int sqr1=Convert.ToInt32(Math.Pow(number,2));

if (sqr == number)
{
    Console.WriteLine("yes");
    
}
else
{
    Console.WriteLine("no");
    
}