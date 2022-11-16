// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int n=GetPositivInt("Задача 69. Введите число: ");
int m=GetPositivInt("Введите степень: ");

Console.WriteLine(ShowMulti(n,m).ToString());


//------------------------------
int GetPositivInt(string message) //просит ввести число в цикле пока пол-ль его не введет
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <0) //бесконечный цикл. ^ - логическое ИЛИ
    {
        Console.Write("Error\n" + message); //если не получилось достать число или значение <0, то пишет "ошибка"
    }
    return value;
}

int ShowMulti(int number, int mul) //рекурсия заменяет цикл!
{
    if (mul==0)
    {
        return 1;
    }
    return ShowMulti(number, mul-1)*number; //число умножается на само себя, а степень каждый раз уменьшается на 1
}