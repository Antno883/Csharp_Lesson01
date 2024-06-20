using System;
using static System.Console;

Clear();

Write("Enter a 3-digital number: ");
int number = int.Parse(Console.ReadLine());

int hundreds = (number-((number / 100)*100))/10;
Console.WriteLine($"{hundreds}"); // Display the hundreds digit                       
