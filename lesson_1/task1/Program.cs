//Определить является первое число квадратом второго
Console.WriteLine("Введите число 1: ");
string number1 = Console.ReadLine();
int x1 = int.Parse(number1);
Console.WriteLine("Введите число 2: ");
string number2 = Console.ReadLine();
int x2 = int.Parse(number2);

if (x1 == x2 * x2)
{
      Console.WriteLine("да");  
}
else Console.WriteLine("нет");


// Определение дня недели по введенному номеру
//Задание 2: юзер даёт число от 1 до 7; написать какой это день недели (словом) ; если не в 1..7 - написать что это не то; исключения не обрабатывать
Console.WriteLine("Введите номер дня недели, от 1 до 7: ");

string value = Console.ReadLine();

bool a = int.TryParse(value, out int s); //проверка может он распарсить или нет. вернет true or false
Console.WriteLine(a);

if (a==true)
{
int num_day = int.Parse(value); //преобразование строки в integer

        if (num_day==1)
        {
                Console.WriteLine("Понедельник");
        }
        else if (num_day==2)
        {
                Console.WriteLine("Вторник");
        }
        else if (num_day==3)
        {
                Console.WriteLine("Среда");
        }
        else if (num_day==4)
        {
                Console.WriteLine("Четверг");
        }
        else if (num_day==5)
        {
                Console.WriteLine("Пятница");
        }
        else if (num_day==6)
        {
                Console.WriteLine("Суббота");
        }
        else if (num_day==7)
        {       
                Console.WriteLine("Воскресенье");
        }
        else
                Console.WriteLine("Что-то не то"); // во всех остальных случаях
}
else Console.WriteLine("Вы ввели набор символов"); //если введут данные, которые невозможно распарсить
