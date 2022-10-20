// Пример 32. Программа замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот

int n = GetNumFromUser("Введите длину массива: ");
int[] inputArray = GetRandomArray(n);
int[] outputArray = new int[n];
for (int i=0; i<n; i++)
{
    outputArray[i] = inputArray[i]*-1;
}
string result1 = string.Join(", ", inputArray);
string result2 = string.Join(", ", outputArray);
Console.WriteLine($"{result1} -> {result2}");


//----------------------
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int N)
{
    int[] array = new int[N];
    for (int i=0; i<N; i++)
    {
        array[i] = new Random().Next(-10,11);
    }
    return array;
} 