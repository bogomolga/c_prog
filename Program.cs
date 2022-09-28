// коммент
//Console.WriteLine("Hello, World!"); - Пример 1

//Пример 2:
/*Console.Write("Введите ваше имя"); //Console.Write() - вывод в одну строку
string username = Console.ReadLine();
Console.WriteLine("Привет, "); //Console.WriteLine() - в конце перейти на новую строку
Console.WriteLine(username);*/

//Console.ReadLine() - считать строку из терминала

//Пример 3: Сложить 2 числа
int a = 3;
int b = 5;
Console.WriteLine(a+b);

//Пример 4: Разделить 2 числа 
int c = 12;
int d = 5;
Console.WriteLine(c/d);

double i = 12;
double f = 5;
double div=i/f;
Console.WriteLine("Деление: "+ div);

/* % - нахождение остатка от деления
Умножение и деление выполняются в 1ю очередь. Потом сложение и вычитание.

new Random().Next(min,max) - генератор случайных чисел. Даст случайное целое число от min до max-1
*/

//Пример 5: Генерация случайных чисел 
Console.WriteLine("Сложим два случайных числа:");
int j = new Random().Next(1, 10); //1 2 3 4 ... 9
Console.WriteLine(j);
int h = new Random().Next(1, 10);
Console.WriteLine(h);
int sum=j+h;
Console.WriteLine("Сумма: "+ sum);