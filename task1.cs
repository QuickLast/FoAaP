//task1
string[] arr = new string[] { "Осипов К.А.", "Куликов Д.Н.", "Осипов Д.Д.", "Куликов Д.Д." };
int count = 0;
foreach(string item in arr)
{
    string[] arr2 = item.Split(' ');
    for(int i = 0; i < arr.Length; i++)
    {
        string[] arr3 = arr[i].Split(' ');
        if (arr2[0] == arr3[0])
            count++;
    }
    Console.WriteLine($"{item} - {count - 1}");
    count = 0;
}