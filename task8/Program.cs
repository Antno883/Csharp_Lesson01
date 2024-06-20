using System;
using static System.Console;

Write("Enter a number:  ");
int number=int.Parse(Console.ReadLine());

if (number%7)&&(number%23)
{
WriteLine("Number is divisible by 7 and 23");
}
else
{
    WriteLine("Number is not divisible by 7 and 23");
}
