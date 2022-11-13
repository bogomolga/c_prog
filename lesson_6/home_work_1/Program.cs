// Задача 41: Польз-ль вводит М чисел. Посчитать, сколько чисел больше 0 ввел пользователь
//0,7,8,-2,-2 -> 2
//-1,-7,567,89,223 -> 3

Console.WriteLine("Введите М чисел через пробел: ");
string stringArray = Console.ReadLine();
string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // метод Split убирает заданный символ из строки 
int k=0;
int[] array = CopyStringToArray(nums);

PrintArray(array);

for (int i=0; i<array.Length; i++)
{
    if (array[i]>0) 
    { 
        Console.Write("* ");
        k++;
    }
}
Console.WriteLine("Количество чисел больше 0: ", k); //считает, но не выводит переменную k в консоль




//---------------

int[] CopyStringToArray(string[] stringArray)
{
    int[] Array = new int[stringArray.Length];
    for (int i=0; i<stringArray.Length; i++)
    {
        bool a = int.TryParse(stringArray[i], out int s); //проверка может он распарсить или нет. вернет true or false
        if (a)
        {
            Array[i] = Convert.ToInt32(stringArray[i]);
        }
        else
        {
            Console.WriteLine("Неправильные данные"); break;
        }
    }
    return Array;
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