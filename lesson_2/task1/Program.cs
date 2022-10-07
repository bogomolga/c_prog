// Пример 9. Программа выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

int randomValue = new Random().Next(10,100); // до 99
int decadeDigit = randomValue / 10;
int unitDigit = randomValue % 10;
int maxValue = decadeDigit;

if (maxValue < unitDigit)
{
    maxValue = unitDigit;
}
Console.WriteLine("Пример 9. randomValue = " + randomValue);
Console.WriteLine("maxValue = " + maxValue);


// Пример 11. Программа выводит целое случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100,1000); // до 999
Console.WriteLine("Пример 11 (вариант 1). randomValue = " + a);

int b = (a / 100) * 10 + a % 10;
Console.WriteLine("Новое число = " + b);


//Вариант с преобразованием в строку

int c = new Random().Next(100,1000); // до 999
Console.WriteLine("Пример 11 (вариант 2). randomValue = " + c);
string myString = c.ToString(); //преобразуем в строку
//Console.WriteLine("ToString = " + myString);
string result = myString.Remove(1,1); // погуглить !!!

Console.WriteLine("Новое число = " + result);