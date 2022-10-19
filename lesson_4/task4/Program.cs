// Пример 30. Выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Пример 30: ");

PrintArray(GetRandomArray(8,0,1));


//------------------
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
