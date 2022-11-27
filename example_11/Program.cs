//Пример 11. Метод = Функция у них. Заполнить массив автоматически и распечатать его.

int[] array = new int[10]; //создай новый массив в котором будет 10 элементов. Будет заполнен нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); //ищем число 4 в сгенеренном массиве и выводим в терминал его индекс
Console.WriteLine(pos); //выведет 0 если такого числа в массиве не будет найдено! Чтоб этого избежать -> int position = -1; Тогда выведет -1 в консоль - "элемент не найден"

//------------------------
void FillArray(int[] collection) // void - метод ничего не возвращает это viod метод
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
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

int IndexOf(int[] collection, int find) //Поиск 1го вхождения заданного числа в массив. Ищет его индекс
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //если убрать break то будет искать последнее вхождение
        }
        index++;
    }
    return position;
}



//Пример: Задача из собеседования - Сколько раз выполнится цикл?

int n = 10;
int count = 0;
for (int i = 0; i < n; i++)
{
    int j = i;
    i=i+j;
    count++;
    Console.WriteLine("i= " + i);
}   Console.WriteLine("Цикл выполнился " + count + " раз");



/* Удалить все вхождения элемента из массива:
1. Enumerable.Where() метод (System.Linq)
The System.Linq.Enumerable.Where() Метод фильтрует последовательность значений на основе предиката. 
В следующем примере кода показано, как мы можем использовать Where() чтобы удалить все вхождения элемента из массива. */

//using System;
//using System.Linq;
 
        int[] array2 = { 1, 3, 4, 5, 4, 2 };
        int item = 4;
 
        array2 = array2.Where(e => e != item).ToArray(); // удалить заданный элемент из массива
        Console.WriteLine(String.Join(",", array2));

/*
    результат: 1,3,5,2
*/