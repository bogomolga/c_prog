//Пример 11. Метод = Функция у них. Заполнить массив автоматически и распечатать его.
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

void PrintArray(int[] col) //вывод массива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
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

int[] array = new int[10]; //создай новый массив в котором будет 10 элементов. Будет заполнен нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); //ищем число 4 в сгенеренном массиве и выводим в терминал его индекс
Console.WriteLine(pos); //выведет 0 если такого числа в массиве не будет найдено! Чтоб этого избежать -> int position = -1; Тогда выведет -1 в консоль - "элемент не найден"


