// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int n = PrintAndGetValue("Задача 19. Введите пятизначное число: ");

if (n>0)
{
    string myString = n.ToString(); //преобразуем в строку
        //Console.WriteLine("myString = "+myString);
    int length = myString.Length;
        //Console.WriteLine("length = "+length);

    if (length!=5)
    {
        Console.WriteLine("Необходимо ввести положительное пятизначное число");
    }
    else
    {
        if (IsPalindrome(myString)==true)
        {
            Console.WriteLine("Является палиндромом");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }
    }    
}
else
{
    Console.WriteLine("Необходимо ввести положительное пятизначное число");
}


bool IsPalindrome (string value)
{
    //bool p;
    if (value[0]==value[4] && value[1]==value[3]) 
    {
        return true;
    }
    else
    {
        return false;
    }
    //return p;
}


//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. (использовать два массива)
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int[] arrayA = new int[3];
int[] arrayB = new int[3];

arrayA[0] = PrintAndGetValue("Задача 21. Введите координату A1: ");
arrayA[1] = PrintAndGetValue("Введите координату A2: ");
arrayA[2] = PrintAndGetValue("Введите координату A3: ");
arrayB[0] = PrintAndGetValue("Введите координату B1: ");
arrayB[1] = PrintAndGetValue("Введите координату B2: ");
arrayB[2] = PrintAndGetValue("Введите координату B3: ");

Console.WriteLine("Расстояние от точки А до точки В: "+ GetDistance3D(arrayA[0],arrayA[1],arrayA[2],arrayB[0],arrayB[1],arrayB[2]));

double GetDistance3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
    return res;
}


//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int N = PrintAndGetValue("Задача 23. Введите N: ");
//n=Math.Abs(n); //берем модуль
string s1="";

if (N>0)
{
    for (int i=1;i<=N;i++)
    {
        if(i!=N)
        {
            s1=s1+Math.Pow(i,3)+", ";
        }
        else
        {
            s1=s1+Math.Pow(i,3)+".";
        }
    }
    Console.WriteLine(s1);
}
else
{
     Console.WriteLine("Надо вводить положительное число");
}



//---------------------------------------------------------------------------------------
int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}


