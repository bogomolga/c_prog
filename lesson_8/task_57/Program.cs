// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/* 0 4 2 0 
3 3 1 1 
1 2 0 2
3 2 4 1 
Массив: [0, 4, 2, 0, 3, 3, 1, 1, 1, 2, 0, 2, 3, 2, 4, 1]
Отсортируем...
Массив: [0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 4, 4]
Подсчет элементов в массиве:
0 Встречается 3 раз
1 Встречается 4 раз
2 Встречается 4 раз
3 Встречается 3 раз
4 Встречается 2 раз */

int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);

int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
int index = 0;
int value;
int count = 1;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        array[index] = matrix[row, col];
        index++;
    }
}

PrintArray(array);
Console.WriteLine("Отсортируем...");
array = SortArray(array);
PrintArray(array);
Console.WriteLine("Подсчет элементов в массиве:");

value = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (value == array[i])
    {
        count++;
    }
    else
    {
        Console.WriteLine($"{value} Встречается {count} раз");
        count = 1;
        value = array[i];
    }
}
Console.WriteLine($"{value} Встречается {count} раз");


//------------------------------
int[,] CreateMatrix(int m, int n) //создаем матрицу
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            array[row, col] = rnd.Next(0, 5);
        }
    }
    return array;
}

void PrintMatrix(int[,] matr) //отображаем матрицу
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Console.Write("Массив: [");
    while (index < length)
    {
        if (index != length - 1)
        {
            Console.Write(collection[index] + ", ");
        }
        else
        {
            Console.Write(collection[index] + "]");
        }
        index++;
    }
    Console.WriteLine();
}

int[] SortArray(int[] collection)
{
    int max;
    int temp;
    for (int i = collection.Length - 1; i >= 1; i--)
    {
        max = i;
        temp = collection[i];
        for (int k = i - 1; k >= 0; k--)
        {
            if (collection[k] > temp)
            {
                temp = collection[k];
                max = k;
            }
        }
        collection[max] = collection[i];
        collection[i] = temp;
    }
    return collection;
}