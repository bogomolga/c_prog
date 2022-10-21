//Факториал через рекурсию
Console.WriteLine("Факториал через рекурсию");

double Factorial (int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}

for (int i=1; i<40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); //про 17! происходит переполнение типа int и появляется отрицательные значения !
    //поэтому тип функции меняем на double
}


//Числа Фибоначчи
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i=1; i<50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); //После 40го числа начинает подтормаживать
}


//Зайти в директорию и обойти все директории внутри
//... на семинаре...
