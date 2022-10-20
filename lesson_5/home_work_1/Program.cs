// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size = PrintAndGetValue("Задача 34. Введите длину массива: ");
int min = 100;
int max = 999;
int[] inputArray = GetRandomArray(size,min,max);

if(isPositiveNumber(size))
{
    PrintArray(inputArray);
    Console.WriteLine("");
    Console.WriteLine("Количество чётных чисел в массиве: "+GetEvenCount(inputArray));
}
else
{
    Console.WriteLine("Неправильные данные");
}


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int n = PrintAndGetValue("Задача 36. Введите длину массива: ");
int min2 = PrintAndGetValue("Введите min ограничение для значений элементов массива: ");
int max2 = PrintAndGetValue("Введите max ограничение для значений элементов массива: ");
int[] inputArray2 = GetRandomArray(n,min2,max2);

if(isPositiveNumber(n))
{
    PrintArray(inputArray2);
    Console.WriteLine("");
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: "+GetSumByPosition(false,inputArray2));
}
else
{
    Console.WriteLine("Неправильные данные");
}


//------------------
int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool isPositiveNumber(int number)
{
    if(number <=1)
        return false;
    return true;
}

int[] GetRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i=0; i<N; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void PrintArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    Console.Write("Массив: [");
    while(index<length)
    {
        if (index!=length-1)
        {
            Console.Write(collection[index]+", ");
        }
        else
        {
            Console.Write(collection[index]+"]");
        }
        index++;
    }
}

int GetEvenCount (int[] collection)
{
    int length=collection.Length;
    int index=0;
    int count=0;
    while(index<length)
    {
        if (collection[index] % 2 == 0) count++;
        index++;
    }
    return count;
}

int GetSumByPosition (bool position, int[] collection) //true - четная позиция в массиве, false - нечетная позиция в массиве
{
    int length=collection.Length;
    int index=0;
    int sum=0;
    while(index<length)
    {
        if (position)
        {
            if (index % 2 != 0) 
            {   
                sum=sum+collection[index];
            }
        }
        else
        {
            if (index % 2 == 0) 
            {
                sum=sum+collection[index];
            }
        }
        index++;
    }
    return sum;
}

