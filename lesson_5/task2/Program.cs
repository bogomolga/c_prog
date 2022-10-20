// Пример 33. Задайте массив. Программа определяет, присутствует ли заданное число в массиве
//4; массив 6,7,19,345,3 -> нет
//-3; массив 6,7,19,345,3 -> да
//Ввести массив через консоль одной строкой через пробел. Потом разделить на элементы массива.

Console.WriteLine("Введите массив чисел через пробел: ");
string getArray = Console.ReadLine();
string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] inputArray = new int[array.Length];

for (int i=0;i<array.Length; i++)
{
    inputArray[i] = int.Parse(array[i]);
}

int searchDigit = PrintAndGetValue("Введите искомое число: ");
int a=0;
for (int i=0; i< inputArray.Length; i++)
{
    if (inputArray[i] == searchDigit)
    {
        a=a+1;
    }
}

if (a>0) // вместо этого использовать break выше
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

//----
int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

