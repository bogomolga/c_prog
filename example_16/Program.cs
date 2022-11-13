// Урок 7
//Собираем строку с числами от a до b, a≤b


string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


/* Запускаем цикл, который будет менять счётчик от значения а, меньшим или равным б. В
результирующую строку будем собирать конкретное значение счётчика. В то же время,
используя рекурсию, надо прописать условие окончания — в нашем случае оно указано в
ветке else, когда возвращаем пустую строку, если условие не выполнилось. Соответственно,
если а меньше или равно b, собираем строку с текущим значением а и вызываем новую копию
метода со значениями аргументов. Первый увеличится на 1.
Дальше в качестве самостоятельной работы предлагаю додумать этот метод так, чтобы
получилось на один вызов рекурсии меньше. Даю небольшую подсказку: надо немного
подкрутить условия и ветку else прописать несколько иначе. */


//Собрать строку с числами от a до b, a ≥ b
string NumbersFor2(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec2(int a, int b)
{
    if (a <= b) return NumbersRec2(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(NumbersFor2(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec2(1, 10)); // 10 9 8 7 6 5 4 3 2 1