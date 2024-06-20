using System;
Console.Clear();
Console.Write("enter a three-digit number: ");
int a=int.Parse(Console.ReadLine());

int b = (a%100)%10;

Console.WriteLine(b);

