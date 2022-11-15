// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int k=4;
int [,] matrix = new int[k,k];

Console.WriteLine("Задача 54: ");
matrix = GetMatrix(matrix);
PrintMatrix(matrix);

//int[] array = new int[m1];
//array = SortArray(SeparateMatrixToRow(matrix,0));

matrix = SortMatrixRows(matrix);
Console.WriteLine("Матрица с отсортированными строками");
PrintMatrix(matrix);


//---------------------------------

int[,] GetMatrix(int[,] matr)
{
    //int[,] matr = new int[matr.GetLength(0), matr.GetLength(1)];

    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    } return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}");
        }
        Console.WriteLine();
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

int[] SeparateMatrixToRow(int[,] matr, int row)
{
    int m = matr.GetLength(1);
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        arr[i] = matr[row, i];
    }
    return arr;
}


int[] SortArray(int[] collection)
{
    int max; 
    int temp;
    for (int i = collection.Length-1; i >= 1; i--)
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


int[,] SortMatrixColumns(int[,] collection) //сортировка матрицы по возрастанию по столбцам
{
    int max;
    int temp;
    for (int j = 0; j < collection.GetLength(0); j++)
    {
        for (int i = collection.GetLength(1) - 1; i >= 1; i--)
        {
            max = i;
            temp = collection[i, j];
            for (int k = i - 1; k >= 0; k--)
            {
                if (collection[k, j] > temp)
                {
                    temp = collection[k, j];
                    max = k;
                }
            }
            collection[max, j] = collection[i, j];
            collection[i, j] = temp;
        }
    }
    return collection;
}

int[,] SortMatrixRows(int[,] collection) //сортировка матрицы по возрастанию по строкам
{
    int max;
    int temp;
    for (int i = 0; i < collection.GetLength(1); i++)
    {
        for (int j = collection.GetLength(0) - 1; j >= 0; j--)
        {
            max = j;
            temp = collection[i, j];
            for (int k = j - 1; k >= 0; k--)
            {
                if (collection[i, k] > temp)
                {
                    temp = collection[i, k];
                    max = k;
                }
            }
            collection[i, max] = collection[i, j];
            collection[i, j] = temp;
        }
    }
    return collection;
}