// Пример 12. Принимает на вход два целочисленных числа и выводит, является ли 2е число кратным 1му. 
// Если 2е число не кратно 1му числу, то выводит остаток от деления

//int a = new Random().Next(100,1000); // до 999
//Console.WriteLine("randomValue = " + a);
//int b = new Random().Next(100,1000); // до 999
//Console.WriteLine("randomValue = " + b);

Console.WriteLine("Задача 12. Введите число 1: ");
string a1 = Console.ReadLine();
Console.WriteLine("Введите число 2: ");
string b1 = Console.ReadLine();
int a = int.Parse(a1);
int b = int.Parse(b1);

int ost = a % b;
if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток: " + ost);
}