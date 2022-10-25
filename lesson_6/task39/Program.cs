// Задача 39: Программа которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]


int n = PrintAndGetValue("Введите длину массива: ");
int min = 0;
int max = 100;

if(isPositiveNumber(n))
{
    int[] array = GetRandomArray(n,min,max);
    PrintArray(array);
    
    Console.WriteLine();
    Console.WriteLine("Новый массив by System: "+String.Join(" ", array.Reverse())); //системная функция разворачивания массива
    
    int[] reverseArray=CreateReversedArray(array);
    Console.WriteLine();
    Console.WriteLine("Новый массив: "+String.Join(" ", reverseArray) + " Исходный: " + String.Join(" ", array));

    ReverseArray(array);
    Console.WriteLine("Новый массив 2: "+String.Join(" ", array));
    
    Console.WriteLine();
    Console.WriteLine("Новый массив by System: "+String.Join(" ", array.Reverse())); //системная функция разворачивания массива. Здесь разворачивает уже назад
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

int[] CreateReversedArray(int[] inArray)
{
    int[] newArray = new int[inArray.Length];
    for(int i=0; i< inArray.Length; i++)
    {
        newArray[i]=inArray[inArray.Length-1-i];
    }
    return newArray;
}

void ReverseArray(int[] inArray) //Будем менять существующий массив
{
    for(int i=0; i< inArray.Length/2; i++)
    {
        int temp=inArray[i];
        inArray[i]=inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i]=temp;
    }
}
