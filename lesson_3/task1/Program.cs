// Пример 17: Принимает на вход координаты точки (x,y), причем x!=0 и y!=0, и выдает номер четверти плоскости, в которой нах-ся эта точка
// 2 | 1
// -----
// 3 | 4


int x = PrintAndGetValue("Введите x: ");
int y = PrintAndGetValue("Введите y: ");
if (x>0 && y>0)
{
    Console.WriteLine("1 четверть");
}
else if (x<0 && y>0)
{
    Console.WriteLine("2 четверть");
}
else if (x>0 && y<0)
{
    Console.WriteLine("3 четверть");
}
else if (x<0 && y<0)
{
    Console.WriteLine("4 четверть");
}
else 
{
    Console.WriteLine("error");
}


// Пример 18: Принимает на вход номер четверти плоскости, выдает диапазон чисел в этой плоскости
// 2 | 1
// -----
// 3 | 4


int n = PrintAndGetValue("Введите номер четверти: ");

switch (n)
{
case 1:
    Console.WriteLine("x>0 и y>0");
    break;
case 2:
    Console.WriteLine("x<0 и y>0");
    break;
case 3:
    Console.WriteLine("x>0 и y<0");
    break;
case 4:
    Console.WriteLine("x<0 и y<0");
    break;
default:
    Console.WriteLine("неверная четверть");
    break;
}

int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}



