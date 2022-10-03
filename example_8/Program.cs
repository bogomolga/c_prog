// Функции и массивы

//Пример 8 и 9. Поиск максимального значения из девяти чисел в массиве через функцию
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = {1,432,5,66,76,88,44,32,103};
array[0] = 12; //запись значения в массив по индексу
//Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);



//Пример 10. Найти первый индекс заданного числа в массиве

int[] a = {1,88,4,66,76,88,44,32,103};
int n = array.Length;
int index = 0;
int find = 88;

while (index < n)
{   
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break; // находит первый индекс числа и прерывает работу
    }
    index++;
}