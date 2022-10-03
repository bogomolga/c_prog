//Задача 3: Вводят число N. Выдать последовательность чисел от -N до N (-3 -2 -1 0 1 2 3)

Console.WriteLine("Введите число: ");

string s = Console.ReadLine();
int N = int.Parse(s); //преобразование строки в integer
int count = 0-N;
while (N>=count) 
{
    Console.Write(count+" ");
    count++;
}
Console.WriteLine();




//Задача 4: вывести последнюю цифру в 3х-значном числе, которое вводит пользователь
Console.WriteLine("Введите 3х-значное число: ");
string str = Console.ReadLine();
int N2 = int.Parse(str); //преобразование строки в integer
Console.WriteLine("Последняя цифра в числе: ");
Console.WriteLine(N2 % 10); // % - нахождение остатка от деления >>> 543/10 = 54,3 (3 последнее число получается)

