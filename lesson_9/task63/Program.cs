// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"


//вариант без рекурсии:





//с рекурсией (из в ДЗ)
int n1 = PrintAndGetValue("Задача 64. Введите значение N: ");

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

int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int AllNaturalNumbers(int n)
{
    if (n > 1) return AllNaturalNumbers(n-1) + 1;
    else return 1;
}