// Задача 40: Принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//Теорема о равенстве треугольника - каждая сторона треугольника меньше суммы двух других сторон.
//Числа не могут быть отрицательные. Целые числа


int AB = PrintAndGetValue("Введите длину 1й стороны треугольника: ");
int BC = PrintAndGetValue("Введите длину 2й стороны треугольника: ");
int AC = PrintAndGetValue("Введите длину 3й стороны треугольника: ");

if(isPositiveNumbers(AB, BC, AC))
{
    if(AB<BC+AC && BC<AB+AC && AC<AB+BC) Console.WriteLine("Такой треугольник может существовать");
    else Console.WriteLine("Треугольник невозможен");
}
else Console.WriteLine("Неправильные данные");


// Задача 42: Преобразовывает десятичное число в двоичное. (двоичное число должно быть строкой) (целое число)
//45 -> 101101
//3 -> 11
//2 -> 10

int n = PrintAndGetValue("Введите число: ");
string res="";
int k=0;

if(isPositiveNumber(n))
{
    Console.WriteLine("Результат 1 (рекурсия): "+Convert(n));
    
    
    while (n > 0)
    {
        k = n % 2;
        n = n / 2;
        res = k + res;
    }
    Console.WriteLine("Результат 2 (while): "+res);
    
    //Вариант 3: можно строку конвертировать в массив чар и вывести через join (без join не работает вывод)
    //char[] array = res.ToCharArray(); //преобразование строки S в массив Char
    //Console.WriteLine("Результат 2: "+String.Join("", array.Reverse()));
    
}
else Console.WriteLine("Неправильные данные");




//------------------
int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool isPositiveNumbers(int a, int b, int c)
{
    if(a <=0 || b<=0 || c<=0)
        return false;
    return true;
}

bool isPositiveNumber(int number)
{
    if(number <=1)
        return false;
    return true;
}

string Convert (int N)
{
    if(N==0) return "";
    int z=N%2;
    return Convert(N/2)+z;
}