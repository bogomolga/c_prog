// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n1 = GetPositivInt("Задача 64. Введите значение N: ");

if (n1 > 1)
{
    for (int i = n1; i > 0; i--)
    {
        if (i == 1)
        {
            Console.Write(AllNaturalNumbers(i) + " ");
        }
        else Console.Write(AllNaturalNumbers(i) + ", ");
    }
}
else Console.WriteLine("Неправильные входные данные");
Console.WriteLine();


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//M = 9; N = 2. -> 44

int M = GetPositivInt("Задача 66. Введите положительное значение M: ");
int N = GetPositivInt("Введите положительное значение N: ");
int length;

if (M<N)
{   length = N - M;
    Console.WriteLine($"{"Сумма значений в промежутке от " + M + " до " + N + ": " + SumBetweenNumbers(M, N, length)}");
}
else if(N<M)
{   length = M - N;
    Console.WriteLine($"{"Сумма значений в промежутке от " + N + " до " + M + ": " + SumBetweenNumbers(N, M, length)}");
}
else Console.WriteLine("Сумма значений в промежутке от " + N + " до " + M + ": " + M);



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
//при m=3 и n=10: 8189

int m = GetPositivInt("Задача 68. Ф-я Аккермана. Введите положительное значения m, где 0 <= m <= 3: ");
int n = GetPositivInt("Введите положительное значение n (значение n не превышает 1000000, если же m = 3, то значение n не превышает 10): ");

if (m >= 0 & m <= 3)
{
    if ((m < 3 & n <= 1000000) || (m == 3 & n <= 24))
        Console.WriteLine($"{"Функция Аккермана при m=" + m + " и n=" + n + ": " + Akkerman(m, n)}");
    else Console.WriteLine("Неправильные данные");
}
else Console.WriteLine("Неправильные данные");



//----------------------
int GetPositivInt(string message) //просит ввести число в цикле пока пол-ль его не введет
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <0) //бесконечный цикл. ^ - логическое ИЛИ
    {
        Console.Write("Error\n" + message); //если не получилось достать число или значение <0, то пишет "ошибка"
    }
    return value;
}

int AllNaturalNumbers(int n)
{
    if (n > 1) return AllNaturalNumbers(n-1) + 1;
    else return 1;
}

int SumBetweenNumbers(int a, int b, int l, int i = 0)
{
    if (i < l)
    {
       return SumBetweenNumbers(a = a + (b - i), b, l, i + 1);
            //for (int i = a+1; i <= b; i++) sum = sum + i; //без рекурсии          
    }
    return a;
}

double Akkerman(double m, double n)
{
    if (m == 0 & n == 0) return 0;
    else
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }

}