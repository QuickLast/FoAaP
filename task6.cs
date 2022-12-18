string s = Console.ReadLine();
string[] words = s.Split(' ');

int minLength = words[0].Length; //минимальная длина слова

foreach (string word in words)
{
    if (word.Length < minLength)
    {
        minLength = word.Length;
    }
}

foreach (string word in words)
{
    if (word.Length == minLength)
    {
        Console.WriteLine(word);
    }
}