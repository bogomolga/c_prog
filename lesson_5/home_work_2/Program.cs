//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

int size = PrintAndGetValue("Задача 38. Введите длину массива: ");
int min1 = 1;
int max1 = 99;
double[] inputArray = GetRandomArray_double(size,min1,max1);

if(isPositiveNumber(size))
{
    PrintArray_double(inputArray);
    Console.WriteLine("");
    double max = GetMaxFromArray(inputArray);
    double min = GetMinFromArray(inputArray);
    Console.WriteLine("Максимальное число в массиве: "+max);
    Console.WriteLine("Минимальное  число в массиве: "+min);
    double result = Math.Round(max-min, 3);
    Console.WriteLine("                     разница: "+result);
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

double[] GetRandomArray_double(int N, int min, int max)
{
    double[] array = new double[N];
    var rnd = new Random();
    for (int i=0; i<N; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()*max, 3); 
    }
    return array;
}

void PrintArray_double(double[] collection)
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

double GetMaxFromArray(double[] collection)
{
    double max = collection[0];
    foreach(double i in collection)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

double GetMinFromArray(double[] collection)
{
    double min = collection[0];
    foreach(double i in collection)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
}