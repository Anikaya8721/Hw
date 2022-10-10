//Задача 10 
Console.WriteLine("Введите трёхзначное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 100 && n < 999)
{
    int a = n / 10;
    int lastDigit = a % 10;
    Console.WriteLine("Вторая цифра: " + lastDigit);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}