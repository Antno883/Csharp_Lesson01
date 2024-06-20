int[] arr = new int[5];
for (int i = 0; i <arr.Length; i++)
{
    arr[i] = i;
    Console.WriteLine($"element[{i}]={arr[i]}");
}

foreach (int i in arr)
{
    Console.WriteLine($"element[{i}]={arr[i]}");
}