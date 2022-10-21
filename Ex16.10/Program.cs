//Задача 27. На входе число, на выходе сумму цифр в этом числе.
/*Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;
int result = 0;
for (int i = 0; i < length; i++)
{
    result = result + Convert.ToInt32(Convert.ToString(number[i]));
}
Console.WriteLine(result);*/


 //Задача 31. Вывести массив из 12 случайных чисел  
/*int []arr = new int [12];
void newArray (int[] array)
{
for (int i=0; i<array.Length; i++)
{
array[i] = new Random().Next(-10,10);
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
//Дополнение к задаче выше.Найти сумму отрицательных и положительных элементов массива
/*int[] arr = new Int32[12];
int positiveNumbersSum = 0;
int negativeNumbersSum = 0;
randomFilling (arr, -9, 9);

for (int i=0; i < arr.Length; i++)
{
    if(arr[i] < 0)
    {
        negativeNumbersSum += arr[i];
    }
    else
    {
        positiveNumbersSum += arr[i];
    }
}
Console.WriteLine();
Console.WriteLine($"сумма положительных чисел{positiveNumbersSum},"+
                  $"сумма отрицательных чисел{negativeNumbersSum}");
int[] randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max);
    }
 return arr;
}            */      

//Задача 32.Вывод случайных чисел в массив(4) ипоменять положительные числа на отрицательные и наоборот
/*int[] array = new Int32[4];

randomFilling (array,-10,10);
arrayOutput (array);
signChange (array);
arrayOutput (array);

void signChange(int[] arr)
{
    for (int i = 0; i< arr.Length; i++)
    {
        arr[i] = arr [i]*-1;
    }
}

void randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i< arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max);
    }
}

void arrayOutput (int[] arr)
{
    for (int i = 0; i< arr.Length; i++)
    {
    Console.Write($"{arr[i]}");
    if (i <(arr.Length-1)) Console.Write($", ");
    }
Console.WriteLine();
}*/

//Задача 33. Задать массив, создать прогу, кот.определит присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится 
// ТОЛЬКО одно сообщение: либо "да", либо "нет".

//1 вариант
/*Console.WriteLine("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска его в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rand = new Random();
bool res = false;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
    if (array[i] == number)
    {
        res = true;
    }
}

Console.WriteLine(string.Join(", ", array));

if (res == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}*/

//2 вариант
/*int[] array = new int[10];
void newArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}
void PrintArray (int[] array)
{
   for (int i = 0; i < array.Length; i++) 
    {
        Console.Write($"{array[i]}");
        if (i<(array.Length-1)) Console.Write($", ");
    }
     Console.WriteLine();
}
newArray(array);
PrintArray(array);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Poisk(array, number)? $"Число {number}входит в массив": $"Число {number} не входит в массив";
Console.WriteLine(result);
bool Poisk(int[]array, int n)
{
    bool h = false;
    for (int i = 0; i < array.Length; i++)
    {
         if(array[i] == n)
         {
            h =true;
            break;
         }
    }
    return h;
}*/

//Задача 34. Задайте массив заполненный случайными полож-ми 3-х значными числами.
//Написать прогу, кот.покажет кол-во четных чисел в массиве.
/*int[] array = new int[8];
Random rand = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count);*/

//Задача 35. Задать одномерный массив из 123 случ-х чисел. Найти кол-во элем-ов массива, значения которых лежат в отрезке(10, 99)
/*int[] arr = new Int32[123];

fillMass(arr, -10, 300);
printArray(arr);
numFind(arr);

int[] fillMass(int[] array, int from, int to)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(from, to + 1);
}
return array;
}

void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

void numFind(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] >= 10 && array[i] <= 99)
{
sum ++;
}
}
Console.WriteLine(sum);
}*/

//Задача 36. Задать одномерный массив заполненный случ.числами.Найти сумму элем-ов, 
//стоящих на нечетных позициях.
/*int[] array = new int[8];
Random rand = new Random();
int n = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
for (int i = 1; i < array.Length; i += 2)
{
    n = array[i] + n;
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элементов array[1], [3], [5], [7] = {n}");*/


//Задача 37. Найти произведение пар чисел в одном-м массиве. Парой считается первые и последнее числа, предпоследнее и второе и т.д.
/*int len = new Random().Next(5,10);
Console.WriteLine(len);

int[] arr = new Int32[len];
double half = Math.Ceiling((Convert.ToDouble(len) / 2));
Console.WriteLine(half);
int[] arr2 = new Int32[Convert.ToInt32(half)];

fillMass(arr, 1, len);
printArray(arr);
numFind(arr, arr2);
printArray(arr2);

int[] fillMass(int[] array, int from, int to)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(from, to + 1);
}
return array;
}

void printArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int[]numFind (int[] array, int[] array2)
{
    for (int i = 0; i < (array.Length)/2; i++)
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0)
    {
        array2 [array.Length / 2] = array [array.Length / 2];
    }
return array2;
}*/

//Задача 38. Задайте массив вещ-ых чисел. Найти разницу между макс. и мин-м элем-ов масива.

/*double[] array = { 8, 2, 55, 90, 5 };
double count = 0;
double max = 0;
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
count = max - min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {count}");*/

