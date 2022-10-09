// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//int a = new Random().Next(100,1000); // до 999
//Console.WriteLine("Задача 10. randomValue = " + a);
//string aStr = a.ToString(); //преобразуем в строку

string str1 = PrintAndGetString("Задача 10. Введите трехзначное число: ");
int str1Length = str1.Length;
bool a = int.TryParse(str1, out int value);
if (a==true)
{
    if (value<0) //Если ввели отрицательное число
    {
        if (str1Length<4 ^ str1Length>4)
        {
            Console.WriteLine("Необходимо ввести трехзначное число");
        }
        else
        {
            Console.WriteLine("Вторая цифра в этом числе: " + str1[2]);
        }
    }
    else
    {
        if (str1Length<3 ^ str1Length>3)
        {
            Console.WriteLine("Необходимо ввести трехзначное число");
        }
        else
        {
            Console.WriteLine("Вторая цифра в этом числе: " + str1[1]);
        }
    }
}
else
{
    Console.WriteLine("Необходимо ввести трехзначное число");
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string str2 = PrintAndGetString("Задача 13. Введите целое число: ");
int str2Length = str2.Length;
    //Console.WriteLine("Длина введенной строки: "+str2Length);
bool b = int.TryParse(str2, out int value2);
    //Console.WriteLine("value2 = "+value2);
if (b==true)
{
    if (value2<0) //Если ввели отрицательное число
    {
        if (str2Length<4)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            Console.WriteLine("Третья цифра в этом числе: " + str2[3]);         
        }
    }
    else
    {
        if (str2Length<3)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            Console.WriteLine("Третья цифра в этом числе: " + str2[2]);
        }        
    }
}
else
{
    Console.WriteLine("Необходимо ввести число (но не более 9 цифр)");
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

string n = PrintAndGetString("Задача 15. Введите цифру дня недели от 1 до 7: ");
switch (n)
{
case "6":
    Console.WriteLine("Выходной день");
    break;
case "7":
    Console.WriteLine("Выходной день");
    break;
case "1":
    Console.WriteLine("Рабочий день");
    break;
case "2":
    Console.WriteLine("Рабочий день");
    break;
case "3":
    Console.WriteLine("Рабочий день");
    break;
case "4":
    Console.WriteLine("Рабочий день");
    break;
case "5":
    Console.WriteLine("Рабочий день");
    break;
default:
    Console.WriteLine("Необходимо ввести цифру дня недели от 1 до 7");
    break;
}




//---------------------------------------------------------------------------------------
string PrintAndGetString(string message) //функция для ввода и считывания строки из консоли
{
    Console.WriteLine(message);
    string s = Console.ReadLine();
    return s;
}