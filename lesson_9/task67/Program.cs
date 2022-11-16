// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Через рекурсию
//453 -> 12
//45 -> 9

int n=GetPositivInt("Задача 67. Введите число: ");

Console.WriteLine(ShowNumFromOneToN(n).ToString());


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


int ShowNumFromOneToN(int number, int sum=0) //рекурсия заменяет цикл!
{
    if (number>0)
    {
        sum+= number%10;
        return ShowNumFromOneToN(number/=10, sum);
    }
    return sum;
}