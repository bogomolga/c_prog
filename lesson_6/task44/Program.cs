// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
//N вводить с консоли и оно целое
//для n=10: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34

//Числа Фибоначчи
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

int n=10;
int [] array = new int[n];
array[0]=0;
array[1]=1;
for (int i=2; i<n; i++)
{
    array[i]=array[i-1]+array[i-2];
}
Console.WriteLine(string.Join(", ", array)); // массивы в консоль умеет выводить только через string.Join



// Задача 45: Программа, которая будет создавать копию заданного массива с помощью поэлементного копирования. 
//Т. е. скопировать один массив в другой
//Усложненный вариант - двумерный массив.
//Длину массива задать в коде.

int l=10;
int [] array1 = new int[l];
int [] array2 = new int[l];
array1 = GetRandomArray(l,1,99);

for (int i=0; i<l; i++)
{
    array2[i] = array1[i];
}

PrintArray(array1);
PrintArray(array2);


// Задача 45: двумерный массив


int k=3;
int [,] matrix1 = new int[k,k];
int [,] matrix2 = new int[k,k];

matrix1[0,0]=1;
matrix1[0,1]=2;
matrix1[0,2]=3;
matrix1[1,0]=4;
matrix1[1,1]=5;
matrix1[1,2]=6;
matrix1[2,0]=7;
matrix1[2,1]=8;
matrix1[2,2]=9;

Console.WriteLine("Копируем двумерный массив: ");
matrix2 = CopyMatrix(matrix1);

for (int i=0; i<matrix2.GetLength(0); i++)
{
    for (int j=0; j<matrix2.GetLength(1); j++)
    {
        Console.Write(matrix2[i,j]);
    }
    Console.WriteLine();
}




//--------------------------------
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

int[,] CopyMatrix(int[,] matrix)
{
    int[,] MatrixCopy = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            MatrixCopy[i,j] = matrix[i,j];
        }
    } return MatrixCopy;
}