// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int n = PrintAndGetValue("Введите длину массива: ");
int min = PrintAndGetValue("Введите min ограничение для значений элементов массива: ");
int max = PrintAndGetValue("Введите max ограничение для значений элементов массива: ");
int[] inputArray = GetRandomArray(n,min,max);

if(isPositiveNumber(n))
{
    PrintArray(inputArray);
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