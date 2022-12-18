string text = Console.ReadLine();
int cnt = 0, max = 0;
foreach (char c in text)
{
    if (char.IsLetter(c)) cnt = 0; else cnt++;
    if (max < cnt) max = cnt;
}
Console.WriteLine(max);