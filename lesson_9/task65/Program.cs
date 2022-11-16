// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

int M = GetPositivInt("Задача 65. Введите положительное значение M: ");
int N = GetPositivInt("Введите положительное значение N: ");

if (IsInputValidate(M, N))
{
    Console.WriteLine($"{"Все натуральные числа в промежутке от " + M + " до " + N + ": " + NumbersRec(M, N)}");
}
else Console.WriteLine("М должно быть больше N");


//--------------------------
int GetPositivInt(string message) //просит ввести число в цикле пока пол-ль его не введет
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <0)
    {
        Console.Write("Error\n" + message);
    }
    return value;
}

bool IsInputValidate(int a, int b)
{
    if (a > b)
        return false;
    return true;
}

string NumbersRec (int a, int b) //рекурсия
{
    if (a<=b) 
    {
        string temp = NumbersRec(a+1, b);    
        return $"{a} " + temp;  
    } 
    else return String.Empty;
}
