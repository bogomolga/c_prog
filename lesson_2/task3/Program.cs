// Пример 14. Принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 161 кратно
// 23 не кратно

Console.WriteLine("Задача 14. Введите число: ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);

int res1 = a % 7;
int res2 = a % 23;

if (res1 == 0 && res2 == 0)
{
    Console.WriteLine("Кратно 7 и 23");
}
else
{
    Console.WriteLine("Не кратно 7 и 23");
}


// Пример 16. Является ли одно число квадратом второго или наоборот

Console.WriteLine("Задача 16. Введите число 1: ");
string c1 = Console.ReadLine();
Console.WriteLine("Введите число 2: ");
string d1 = Console.ReadLine();
int c = int.Parse(c1);
int d = int.Parse(d1);

double result1 = Math.Pow(c,2);
double result2 = Math.Pow(d,2);

if (c == result2 ^ d == result1) // ^ - ИЛИ
{
    Console.WriteLine("Одно число квадрат второго");
}
else
{
    Console.WriteLine("Не квадрат");
}