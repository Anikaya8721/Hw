//Задача 25
/*Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень первого числа: ");
int m = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 1;

for (i = 1; i <= m; i++)
{
    sum = n * sum;
}
Console.WriteLine($"Число {n} в степени {m} равно = {sum}");*/

//Задача 27
/*Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int res = 0;
int sum = 0;

while (n > 10)
{
    num1 = n % 10;
    sum = sum + num1;
    n = n / 10;
}
if (n<10)
{
    res = sum + n;
}

Console.WriteLine($"Сумма цифр во введенном числе {n} = {res}");*/

//Задача 29
/*void newArray (int[] array)
{
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        Console.WriteLine($"Введите элемент массива [{i}]:");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
        i++;
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write(arr[i] + " ");
        i++;
    }
}
int[] array = new int[8];
int count = array.Length;

newArray(array);
PrintArray(array);*/


