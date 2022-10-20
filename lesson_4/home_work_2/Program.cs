//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int a = PrintAndGetValue("Задача 27. Введите положительное число: ");

if(isPositiveNumber(a))
{
    Console.WriteLine("Cуммa цифр в числе = "+CalculateDigitsSum(a));
}
else
{
    Console.WriteLine("Неправильные данные");
}

//---------------------------------------------------------------------------------------
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

int CalculateDigitsSum(int number) //Cуммa цифр в числе
{
    int s=0;
    while (number>0) 
    {
        s=s+(number % 10);
        number /=10;
    }
    return s;
}
