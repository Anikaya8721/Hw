//Задача 47. Задайте двумерный массив m*n, заполненный случ. вещественными числами. 
// m = 3, n = 4  
//0,5  7  -2  -0,2
//1  -3,3  8  -9,9
//8  7,8  -7  1,9
// Console.WriteLine("Введите высоту двумерного массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину двумерного массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n];

// void FillArray (double[,]array)
// {
//     Random random = new Random();
//     {
//         for (int i = 0; i < array.GetLength(0); i++ )
//         {
//             for (int j = 0; j < array.GetLength(1); j++ )
//             {
//                 array[i, j] = random.NextDouble() * random.Next(-40, 120);
//                 array[i, j] = Math.Round(array [i, j], 1);
//             }
//         }
//     }
// }
// void Print(double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++ )
//     {
//         for (int j = 0; j < array.GetLength(1); j++ )

//         {
//             Console.Write(array[i, j] +" ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArray(array);
// Print(array);



//Задача 50.Напишите прогу,кот. на входе принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
//Задана массив: 1 4 7 2
//               5 9 2 3
//               8 4 2 4   17 -> такого элемента в массиве нет

// Console.WriteLine("Введите индекс строки: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс столбца: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int leftRange = 10; 
// int rightRange = 99;
// int[,] matrix = FillMatrix(4, 4);

// PrintMatrix(matrix);
// FindIndexMatrix(matrix);


// int[,] FillMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     Random rand = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindIndexMatrix(int[,] matrix)
// {
//     if (m >= 0 && m < matrix.GetLength(0) && n >= 0 && n < matrix.GetLength(1))
//     {
//         Console.WriteLine("Значение данного элемента: "+ matrix[m, n]);
//     }
//     else
//     {
//         Console.WriteLine("А вот и нет такого элемента! Попробуйте снова)");
//     }
// }
// FindIndexMatrix(matrix);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце. Например массив: 1 4 7 2
//                                    5 9 2 3 
//                                    8 4 2 4
// Среднее арифметическое каждого столбца: 4,6;  5,6;  3,6;  3.

Console.WriteLine("Введите высоту двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int leftRange = 0;
int rightRange = 10;
int[,] matrix = Fill(m, n);

Print(matrix);
FindArithmeticMatrix(matrix);

int[,] Fill(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindArithmeticMatrix(int[,] matrix)
{
    double arithmetic = 0;
    double sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arithmetic = sum / matrix.GetLength(0);
        Console.Write($"Сумма {j + 1} столбца = {sum} ");
        Console.WriteLine($" Среднеарифметическое = {arithmetic:F2}");
        sum = 0;
    }
}