// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 8 & num > 5)
{
    Console.WriteLine("Ура, выходной!");
}
else if (num >0 & num < 6)
{
    Console.WriteLine("Опять работать");
}
else
{
Console.WriteLine("некоректные данные");
}
