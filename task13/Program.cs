Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (number > 99)
{
    k = number;
    d = k % 10;
    while (k >= 1000)
    {
        k /= 10;
        d = k % 10;
    }
Console.WriteLine($"третья цифра {d}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
