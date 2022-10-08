//Пример 22: Принимает челочисленное число N и выдает таблицу квадратов чисел от 1 до N
//5 -> 1,4,9,16,25.
//2 -> 1,4.

int n = PrintAndGetValue("Введите N: ");
//n=Math.Abs(n); //берем модуль
string s="";

if (n>0)
{
    for (int i=1;i<=n;i++)
    {
        if(i!=n)
        {
            s=s+Math.Pow(i,2)+", ";
        }
        else
        {
            s=s+Math.Pow(i,2)+".";
        }
    }
    Console.WriteLine(s);
}
else
{
     Console.WriteLine("Надо вводить положительное число");
}

int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}
