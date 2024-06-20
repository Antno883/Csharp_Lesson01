using System;
using static System.Console;

Clear();

Write("Enter number 1-7: ");
int number = int.Parse(Console.ReadLine());


if (number > 7) {
    WriteLine("Entered number is not 1-7.");
    return;
}
else
{
    if (number == 7 || number == 6)
    {
        WriteLine("Yes today is Sunday and rest day.");
    }
    else
    {
        WriteLine("Yes today is a working day.");
    }
}