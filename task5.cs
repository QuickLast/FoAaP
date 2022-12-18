string text = Console.ReadLine();
string[] arr = text.Split(' ');
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
        Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.WriteLine(arr.Length);