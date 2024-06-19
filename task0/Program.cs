Console.Clear();
Console.Write("Input value = ");
int number=int.Parse(Console.ReadLine());
int sqr=number*number;

Console.WriteLine($"square number = {sqr}");

int sqr1=Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"square number = {sqr1}");


