// String

string text="все пробелы в тексте заменить на другой символ";
string newText=Replace(text, ' ', '|');
Console.WriteLine(newText);

//------------------
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length=text.Length;
    for(int i=0; i<length; i++)
    {
        if(text[i]==oldValue) result= result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}


//Сортировка методом выбора

Console.WriteLine("Сортировка методом выбора:");

int[] arr = {1,5,4,3,2,6,7,1,1};
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {
        int minPosition=i;
        
        for(int j=i+1; j<array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition=j;
        }
        
        int temp=array[i];
        array[i]=array[minPosition];
        array[minPosition]=temp;
    
    }
}