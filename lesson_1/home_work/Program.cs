// Домашнее задание №1

//Задача 2: На вход принимает 2 числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("Задача 2. Введите число 1: ");
string number1 = Console.ReadLine();
int x1 = int.Parse(number1);
Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine();
int x2 = int.Parse(number2);

if (x1 > x2)
{
      Console.WriteLine("Наибольшее число: "+x1);  
}
else if (x1 == x2)
{
    Console.WriteLine("Оба числа равны");
}
else Console.WriteLine("Наибольшее число: "+x2);


//Задача 4: На вход принимает 3 числа и выдает максимальное из них

Console.WriteLine("Задача 4. Введите число 1: ");
string num1 = Console.ReadLine();
int a = int.Parse(num1);
Console.WriteLine("Введите число 2: ");
string num2 = Console.ReadLine();
int b = int.Parse(num2);
Console.WriteLine("Введите число 3: ");
string num3 = Console.ReadLine();
int c = int.Parse(num3);

int max = a;

if (b > max)
{
      max = b;  
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Максимальное число: "+max);


//Задача 6: На вход принимает число и выдает, является ли это число четным (делится ли оно на 2 без остатка)

Console.WriteLine("Задача 6. Введите число: ");
string n1 = Console.ReadLine();
int w = int.Parse(n1);

int chet = w % 2; // % - нахождение остатка от деления >>> 5/2 = 2,5
    //Console.WriteLine("остаток от деления: "+chet); 
if (chet == 0)
{
      Console.WriteLine("Число четное");   
}
else Console.WriteLine("Число нечетное");


//Задача 8: На вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");

string s = Console.ReadLine();
int N = int.Parse(s); //преобразование строки в integer
int count = 2;
int ch1 = N % 2; 
    Console.WriteLine("остаток от деления ch1: "+ch1); 
if (ch1 == 0) //если число четное
{
    while (N>=count) 
    {
        int ch2 = count % 2; 
        if (ch2 == 0) //если число четное
        {    Console.Write(count+" ");
        }
        count++;
    }
}
else 
{ 
    while (N-1>=count) 
    {
        int ch2 = count % 2; 
        if (ch2 == 0) //если число четное
        {    Console.Write(count+" ");
        }
        count++;
    } 
}
Console.WriteLine(" ");