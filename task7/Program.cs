using System;
using static System.Console;

Clear();
Write("Enter first number: ");
int a=int.Parse(Console.ReadLine());
Write("Enter second number: ");
int b=int.Parse(Console.ReadLine()) ;


if (a%b==0)
{
    WriteLine("First number is divisible by second number");

}
else
{
    WriteLine("second number is not divisible by first number");
    }