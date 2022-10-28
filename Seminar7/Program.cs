//Задача 46. Задайте двумерный массив размером m и n, заполненный случайными
// целыми числами. Например m=3, n=4
                         // 1 4 8 1 9
                         // 5-2 3 3 -2
                         // 7 7 3 8 1
/*Console.WriteLine("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину матрицы: ");
int n = int.Parse(Console.ReadLine()!);

int[,]array = new int[m, n];

void FillArray (int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++ )
    {
        for (int j = 0; j < matr.GetLength(1); j++ )
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void Print(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++ )
    {
        for (int j = 0; j < matr.GetLength(1); j++ )
        {
            Console.Write(matr[i, j] +" ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Print(array);*/


//Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
/*Console.WriteLine("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

fillArray(array);
printArray(array);

int[,] fillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = i + j;
}
}
return arr;
}

void printArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write(arr[i, j] + " ");
}
Console.WriteLine();
}
}*/

//Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты. 
//Например: 1 4 7 2     1 4 49 2
        //  5 9 2 3     5 81 2 9
        //  8 4 2 4     62 4 4 4

/*int[,]array = new int [3,4];
fillArray(array);
arrayOutput(array);
square (array);
arrayOutput(array);

void fillArray (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
   {
   for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = new Random(). Next(1,10);
      }
   }
}
void square (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i+=2)
   {
   for (int j = 0; j < matrix.GetLength(1); j+=2)
      {
        matrix[i, j] = matrix[i, j] * matrix[i, j];
      }
   }
}

void arrayOutput (int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
      Console.WriteLine(" ");
   }
   Console.WriteLine(" ");
}*/
//вариант от преподавателя:
/*Console.WriteLine("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину матрицы: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matr = new int [m, n];

void Fill (int[,] matr)
{
for ( int i = 0; i < matr.GetLength(0); i++)
   {
   for (int j = 0; j < matr.GetLength(1); j++)
      {
        matr[i, j] = new Random(). Next(1,10);
      }
   }
}
Fill(matr);
Console.WriteLine();
Console.WriteLine("Исходная матрица: ");
Print(matr);

for ( int i = 0; i < matr.GetLength; i+=2)
   {
   for ( int j = 0; j < matr.GetLength; j+=2)
      {
        matr[i, j] *= matr[i, j];
      }
}


void Print (int[,] matr)
{
   for ( int i = 0; i < matr.GetLength(0); i++)
   {
      for ( int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
      Console.WriteLine();
   }
}
   Console.WriteLine("Измененная матрица: ");
   Print(matr);*/


//Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали.

/*Console.WriteLine("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Console.WriteLine();
fillArray(array);
printArray(array);
Console.WriteLine();
Console.WriteLine(indexFinder(array));


int[,] fillArray (int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
   {
   for (int j = 0; j < arr.GetLength(1); j++)
      {
        arr[i, j] = new Random(). Next(1,10);
      }
   }
   return arr;
}
 int indexFinder (int[,] arr)
{
   int c = 0;
   int min = arr.GetLength(0);
  
    if (arr.GetLength(0) > arr.GetLength(1))
      {
      min = arr.GetLength(1);
      }
    for (int i = 0; i < min; i++)
      {
      c += arr [i, i];
      }
return c;
}

void printArray (int[,]arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         Console.Write(arr[i, j]+ " ");
      }
      Console.WriteLine();
   }
}*/
//вариант от преподавателя:
 /*Console.WriteLine("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину матрицы: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matr = new int [m, n];

void Fill (int[,] matr)
{
for ( int i = 0; i < matr.GetLength(0); i++)
   {
   for (int j = 0; j < matr.GetLength(1); j++)
      {
        matr[i, j] = new Random(). Next(1,10);
      }
   }
}

void Print (int[,] matr)
{
   for ( int i = 0; i < matr.GetLength(0); i++)
   {
      for ( int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
      Console.WriteLine();
   }
}
   Console.WriteLine("Исходная матрица: ");
   Fill(matr);
   Print(matr);

   int sum = 0;
   Console.WriteLine();
   for ( int i = 0; i < matr.GetLength(0); i++)
   {
      for ( int j = 0; j < matr.GetLength(1); j++)
      {
         if (i==j)
         {
         sum=sum+matr[i, j];
         } 
      }
   }
Console.WriteLine("Сумма элементов главной диагонали=: " + sum);*/