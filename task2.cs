static string check(string s)
{
    bool cond = true;
    foreach (char c in s)
    {
        if (c == '0' || c == '1')
            continue;
        else
            cond = false;
        break;
    }
    if (cond == true)
        return s;
    else
        return "404";
}
string temp = "";
while (true)
{
    Console.Write("Введите число в двоичной системе счисления: ");
    string s = Console.ReadLine();
    s = check(s);
    if (s == "404")
        continue;
    else
        temp = s;
        break;
}
Console.WriteLine(Convert.ToString(Convert.ToInt32(temp, 2), 10));


