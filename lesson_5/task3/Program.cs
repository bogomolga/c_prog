// Пример 35. Задайте одномерный массив из 123 случайных чисел. Найдите кол-во элементов массива, значения которых лежат в отрезке [10,99]
//[5,18,122,6,2] -> 1
//[1,2,3,4,5,6,7,8,9] ->0

int size=123;
int[] inputArray = GetRandomArray(size);
int count=0;
for (int i=0; i<size; i++)
{
    if (inputArray[i]>=10 && inputArray[i]<=99)
    {
        count++;
    }
}
string result = string.Join(", ", inputArray);
Console.WriteLine("Пример 35. Кол-во элементов массива, значения которых лежат в отрезке [10,99]: ");
Console.WriteLine($"{result} -> {count}");

//--------------------
int[] GetRandomArray(int N)
{
    int[] array = new int[N];
    for (int i=0; i<N; i++)
    {
        array[i] = new Random().Next(1,1000);
    }
    return array;
} 