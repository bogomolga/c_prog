// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"


//вариант без рекурсии:





//с рекурсией (из в ДЗ)
int n1=GetPositivInt("Задача 64. Введите значение N: ");

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


//----------------------

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

int AllNaturalNumbers(int n)
{
    if (n > 1) return AllNaturalNumbers(n-1) + 1;
    else return 1;
}