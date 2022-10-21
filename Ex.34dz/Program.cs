//Задача 34. Задайте массив заполненный случайными полож-ми 3-х значными числами.
//Написать прогу, кот.покажет кол-во четных чисел в массиве.
/*int[] array = new int[5];
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


//Задача 36. Задать одномерный массив заполненный случ. числами. Найти сумму элем-ов, стоящих на нечетных позициях.

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

