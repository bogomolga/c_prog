// Пример 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем 1й и последний элемент, второй и предпоследний и т.д.. Результат запишите в новый массив
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6 ] -> 36 21

Console.WriteLine("Введите элементы массива через пробел: ");
int[] inputArray = GetArrayFromString(Console.ReadLine());

if (inputArray.Length % 2 == 0)
{
    int[] outputArray = new int[inputArray.Length/2];

}
else
{
    int[] outputArray = new int[inputArray.Length/2+1];
}

PrintArray(outputArray);

for (int i=0; i<inputArray.Length; i++)
{
    inputArray[i] = inputArray[i] * inputArray[inputArray.Length-1-i];
}


//-------------------
int[] GetArrayFromString(string stringArray) //получаем массив введенный через пробел из консоли
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

void PrintArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    Console.Write("Массив: [");
    while(index<length)
    {
        if (index!=length-1)
        {
            Console.Write(collection[index]+", ");
        }
        else
        {
            Console.Write(collection[index]+"]");
        }
        index++;
    }
}
