// See https://aka.ms/new-console-template for more information
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число, которое будут возводить в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое соответствует степени: ");
int b = Convert.ToInt32(Console.ReadLine());

string Method(int x, int y)
{
    int i = 1; 
    int result = 1;

    while (i <= y)
    {
        result = result*x;
        i++;
    }
    return $"Число {x}, возведенное в степень {y} = {result}";
}
string res = Method(a, b);
Console.WriteLine(res);