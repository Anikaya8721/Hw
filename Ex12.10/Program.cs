//Задача 24
/*Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
{
sum += i;
}
Console.WriteLine("Сумма: ");
Console.Write(sum);*/

//Задача 26
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (count = 0; n > 0; count++)
// {
//   n = n / 10;
// }
// Console.WriteLine("Количество цифр в числе: ");
// Console.Write(count);
//или 2 вариант:
/*Console.WriteLine("Количество цифр в числе: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(num != 0)
{
num /= 10;
count += 1;
}
Console.WriteLine(count);*/


//Калькулятор Александра
/*Console.WriteLine("Введите 1 число");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Что бы произвести сложение введите 0; вычитание 1; умножение 2; деление 3");
double g = Convert.ToInt32(Console.ReadLine());
double d = a + b;
double f = a - b;
double e = a * b;
double j = a / b;

if (g == 0)
{
    Console.Write("= ");
    Console.WriteLine(d);
}    
    
if (g == 1)
{   
    Console.Write("= ");
    Console.WriteLine(f);
}   

if (g == 2)
{  
    Console.Write("= ");
    Console.WriteLine(e);
}  

if (g == 3)
{  
    Console.Write("= ");
    Console.WriteLine(j);
}
*/

//Задача 28
/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = adition(number);
Console.WriteLine(result);
int adition(int number)
{
int count = 1;
for (int i = 1; i <= number; i++)
{
count *= i;
}
return count;
}*/

//Задача 30
/*void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}

int[] array = new int[8];
int count = array.Length;

FillArray(array);
PrintArray(array);*/
//или
/*int []arr = new int [8];
void newArray (int[] array)
{
for (int i=0; i<array.Length; i++)
{
array[i] = new Random().Next(0,2);
}
}
void PrintArray (int[] array)
{
   for (int i=0; i<array.Length; i++) 
   {
    Console.Write($"{array[i]}");
    if(i<(array.Length-1))Console.Write($", ");
   }
   Console.WriteLine();
}
newArray(arr);
PrintArray(arr);*/

