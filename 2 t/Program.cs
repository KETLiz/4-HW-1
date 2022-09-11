// See https://aka.ms/new-console-template for more information
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

string Summa(int x)
{
    int sum = 0;
    while (x > 0)
    {
        sum = sum + x%10;
        x = x/10;
    }
    return $"Сумма цифр в числе равна {sum}";
}
string result = Summa(n);
Console.WriteLine(result);