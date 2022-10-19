// Пример 26. Принимает на вход число и выдает кол-во цифр в числе. (операции для типа string не использовать)
//456 -> 3
///78 -> 2
//89126 -> 5

int a = Math.Abs(PrintAndGetValue("Введите число А: "));
int count=1;

while (a / 10 > 0)
{
    a= (a - a % 10) /10;
    count++;
}

Console.WriteLine("Количество цифр: "+ count);

//------------------
int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}


