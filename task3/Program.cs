using System;
Console.Clear();
Console.Write("Input value 1 = ");
int a=int.Parse(Console.ReadLine());
int b = -a;

while (b<=a)
{
    Console.WriteLine($"{b}");
    b++;     
}


//for (int i = 1; i < n; i++)
//{
//    Console.WriteLine(i);
//
//}