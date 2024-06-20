using System;
using static System.Console;

Clear();

Write("Enter a 3-digital number: ");
int number = int.Parse(Console.ReadLine());


if (number < 100) {
    WriteLine("Entered number is not a 3-digit.");
    return;
}
 
 int thirdDigit = number % 100%10;
 if (thirdDigit == 0) { 
    WriteLine("Третьей цифры нет.");
 } else {
 WriteLine(thirdDigit);
 }

/*
int tens = (number%100)/10;
int ones = number%10;
int hundreds = number/100;
Console.WriteLine($"{ones} {tens} {hundreds}");
// int hundreds = (number-((number / 100)*100))/10;
// Console.WriteLine($"{hundreds}"); // Display the hundreds digit                       
*/