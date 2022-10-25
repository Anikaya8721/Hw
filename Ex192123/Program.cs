//Задача 19
//Как можно перевернуть число
/*Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string textNumber = num.ToString();
char[]text = textNumber.ToCharArray();
Array.Reverse(text);
Console.WriteLine(text);*/
/*Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int numbersave = n;
int revnumber = 0;

while (n > 0)
{
    int dig = n % 10;
    revnumber = revnumber * 10 + dig;
    n = n / 10;
}
if (numbersave == revnumber)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");


//Задача 21
Console.WriteLine("A1(x1;y1;z1),A2(x2;y2;z2)");
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A1A2 length is: "+Math.Round(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)),2));*/

//Задача 23
/*bool one =true;
while(one)
{
    try
{
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 0;
for(int i = 1;i <=n; i++)
{
    index=(int)Math.Pow(i,3);
if(i==n)Console.Write(index+".");
else
Console.Write(index+",");
}
one = false;
}
catch
{
    Console.WriteLine("Ошибка ввода попробуйте ещё раз: ");
}}*/