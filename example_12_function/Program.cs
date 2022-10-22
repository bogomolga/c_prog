//4 вида методов (функций)
// Вид 1 - ничего не принимают и не возвращают - void

void Method1()
{
    Console.WriteLine("Hello, World!");
}
Method1();


//Вид 2 - ничего не возвращают, но принимают - void

void Method2(string msg, int value)
{
    Console.WriteLine(msg);
    Console.WriteLine(value);
}
Method2(value: 16, msg: "message"); //именованые аргументы. порядок аргументов при этом можно не соблюдать !


//Вид 3 - что-то возврают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year=Method3();
Console.WriteLine(year);


//Вид 4 - что-то принимают и что-то возвращают

string Method4(int count, string s)
{
    int i=0;
    string result = String.Empty; //result = ""

    while (i<count)
    {
        result=result+s;
        i++;
    }
    return result;
}

string res=Method4(10, "привет ");
Console.WriteLine(res);


//for

string Method5(int count, string s)
{
    string result = String.Empty; //result = ""
    for(int j=0; j<count; j++)
    {
        result=result+s;
    }
    return result;
}

string r=Method4(15, "for ");
Console.WriteLine(r);


//Таблица умножения. Интерполяция строк: Console.WriteLine($"{i} x {j} = {i*j}")
Console.WriteLine("Интерполяция строк");
    for (int i = 2; i <=10; i++)  
    {
        for (int j = 2; j <=10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i*j}");
        }
        Console.WriteLine();
    }