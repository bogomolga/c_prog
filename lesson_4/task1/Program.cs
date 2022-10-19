// Пример 24. Принимает на вход число А и выдает сумму чисел от 1 до А
Console.WriteLine("Введите А");

int A = int.Parse(Console.ReadLine());
bool isValid = IsInputValid(A);
if(isValid)
{
    int sum = CalculateSum(A);
    Console.WriteLine("Сумма = "+sum);
}
else
{
    Console.WriteLine("Неправильные данные");
}

//---------------------------------------
int CalculateSum(int n) //сумма чисел от 1 до n
{
    int sum = 0;
    for (int i=1; i<=n; i++)
    {
        sum=sum+i;
    }
    return sum;
}


bool IsInputValid(int a) //проверка что число положительное
{
    if(a <=1)

        return false;

    return true;
}
