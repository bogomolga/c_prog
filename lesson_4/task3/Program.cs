// Пример 28. Принимает на вход число N и выдает произведение чисел от 1 до N (не Факториал)
//11 -> 39916800
//78 -> 0 Не может посчитать
//9 -> 362880

int n = PrintAndGetValue("Задача 28. Введите число: ");
int b=1;
int counter=1;

while(n>=counter)
{
    b=b*counter;
    counter++;
}

Console.WriteLine("Произведение чисел: "+b);


//------------------
int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

