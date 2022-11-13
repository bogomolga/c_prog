// Урок 6. Код не запускается!

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(',')) //получили массив координат. Items делаются разбиением строки через запятую
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //текущий массив координат превратим в кортеж чисел. делаем разбор строки. теперь будет массив кортежей *
                //e - это элемент кортежа
                .Where(e=> e.x % 2 == 0) //домножаем только первые (х) четные координаты набора на 10, строкой ниже
                .Select(point => (point.x * 10, point.y)) //X умножаем на 10
                .ToArray(); //превращаем в массив

/* for (int i=0; i < data.Length; i++)
{
    //Console.WriteLine(data[i]);
    for (int k=0; k < data[i].Length; k++)
    {
        Console.WriteLine(data[i][k]);   
    }
    Console.WriteLine();
} */

//вывод массива кортежей *
for (int i=0; i < data.Length; i++)
{
    //Console.WriteLine(data[i].y*10); //Y умножаем на 
    Console.WriteLine(data[i]);
}
    //в консоли будет:
    //1,2 2,3 4,5 6,7
    //(20,3)
    //(40,5)
    //(60,7)