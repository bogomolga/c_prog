//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Применять Math.Pow нельзя!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double a = PrintAndGetValue_double("Задача 25. Введите любое число А: ");
int b = PrintAndGetValue("Введите положительное число B: ");

bool isValid = isPositiveNumber(b);
if(isValid)
{
    //double s = CalculateStepen(a,b);
    Console.WriteLine("А в степени В = "+CalculateStepen(a,b));
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

double PrintAndGetValue_double(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    double value = double.Parse(Console.ReadLine());
    return value;
}

bool isPositiveNumber(int number)
{
    if(number <=1)
        return false;
    return true;
}

double CalculateStepen(double value, int stepen) //Возводит value в степень stepen
{
    double s=value;
    int count=1;
    while (count<stepen) 
    {
        s=s*value;
        count++;
    }
    return s;
}