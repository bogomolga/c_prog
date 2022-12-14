// Урок 7
//Сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

/* 
в этой задаче мы рассмотрели пример использования итеративного и рекурсивного
подхода. Теперь вы, как математики, должны знать, как на самом деле решается эта задача.
Тем, кто забыл, напоминаю, что у нас есть формула, позволяющая найти сумму чисел от 1 до n. */


// Факториал числа

double FactorialFor(int n)
{
int result = 1;
for (int i = 1; i <= n; i++) result *= i;
return result;
}

double FactorialRec(int n)
{
if (n == 1) return 1;
else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

/*Соответственно, используя итеративный подход, мы описываем
функцию, принимающую значение того самого n, факториал которого требуется найти.
Дальше заводим некоторую результирующую переменную, по умолчанию будет нейтральный
по умножению элемент — 1. Далее идёт цикл от 1 до момента, пока i меньше или равно n.
Соответственно, будем домножать результат на текущее значение i, а после этого —
возвращать результат.
Если у нас рекурсивный подход, обязательное условие выхода — то, что n, аргумент нашей
функции, стал равен 1. В этом случае будем возвращать 1. Кстати, по-хорошему надо описать
ещё и 0, потому что 0! тоже считается 1. И остальные условия, когда мы будем возвращать
текущее значение n, умноженное на вызов рекурсивной функции с аргументом на 1 меньше. А
результат будет одинаковым. */


//Вычислить а в степени n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a; //можно записать одной строкой вместо 2х
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024
