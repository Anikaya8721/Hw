Console.Write("*****************************\n Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("*****************************\n Введите второе число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("*****************************\n Введите третье число: ");
int b = Convert.ToInt32(Console.ReadLine());
{
if ( n > a&n > b ) Console.WriteLine("Первое число максимальное"); 
else if ( a > n&a > b ) Console.WriteLine("Второе число максимальное");
else if (b > n&b > a ) Console.WriteLine("Третье число максимальное");
}
