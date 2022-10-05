Console.Write("*****************************\n Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("*****************************\n Введите второе число: ");
int a = Convert.ToInt32(Console.ReadLine());
{
if (n > a) 
{ 
Console.WriteLine("Первое число больше!");}
else if (n < a ) Console.WriteLine("Второе число больше");
else if (n == a ) Console.WriteLine("Числа равны, повторите попытку");
}
