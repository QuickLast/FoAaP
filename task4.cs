int i = 0;
bool good;
do
{
    Console.Write("Введите шестнадцетеричное число:");
    try
    {
        good = true;
        i = Convert.ToInt32(Console.ReadLine(), 16);
    }
    catch (Exception e)
    {
        Console.WriteLine("Не понял");
        good = false;
    }
} while (!good);
Console.WriteLine(good);
Console.WriteLine(i);