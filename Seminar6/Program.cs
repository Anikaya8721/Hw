//Написать прогу, кот. перевернет одномерный массив.
//например : [1 2 3 4 5]->[5 4 3 2 1]
/*int[] array = new int[10];
Console.WriteLine("Ваш массив: ");
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i]+" ");
    }
    for (int i = 0; i < array.Length/2; i++)
    {
        int t = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = t;
    }
    Console.WriteLine();
    Console.Write("Перевернутый массив: ");
    for (int i = 0; i < array.Length; i++)
{
    
     Console.Write(array[i]+" ");
     }}*/

//Задача 40. Написать прогу, кот. принимает на вход 3 числа и проверяет может ли существовать
//треугольник со сторонами такой длины. Вспоминая теорему о неравенстве треуг-ка:
//каждая сторона треуг-ка меньше суммы 2-х других сторон.
/*Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if(a + b > c && a +  c> b && b + c > a)
{
    Console.WriteLine("Это треугольник");
}
else Console.WriteLine("Это не треугольник");*/



//Задача 42. Написать прогу, кот. будет преобразовывать десятичное число в двоичное:
//45->101101, 3->11, 2->10
/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string count = null;

while (number != 0)
{
count += number % 2;
number /= 2;
}
for(int i = count.Length-1; i >= 0; i--  )
{
Console.Write(count[i]);
}*/