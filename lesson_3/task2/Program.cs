//Пример 21: Расстояние от точки А до точки В
//Math.Sqrt возвращвет double

int x1 = PrintAndGetValue("Введите x1: ");
int y1 = PrintAndGetValue("Введите y1: ");
int x2 = PrintAndGetValue("Введите x2: ");
int y2 = PrintAndGetValue("Введите y2: ");

int PrintAndGetValue(string message) //функция для ввода и считывания значения из консоли
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

double GetDistance (int x1, int x2, int y1, int y2)
{
    double res = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
    return res;
}

Console.WriteLine("Расстояние от точки А до точки В: "+ GetDistance(x1,x2,y1,y2));