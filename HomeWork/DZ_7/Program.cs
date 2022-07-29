

// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] matrix = new double[3, 4];
Random rand = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rand.Next(-10, 10) + rand.NextDouble();
        Console.Write(Math.Round(matrix[i, j],1) + "\t");
    }
    Console.WriteLine();
}

// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] myArray = new int[3, 4];

// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         Console.WriteLine("строка: " + i + "\t" + "столбец: " + j);
//         myArray[i, j] = int.Parse(Console.ReadLine());
//     }
// }
// Console.WriteLine();
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         Console.Write(myArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите число, которое необходимо найти в массиве: ");
// int findNumber = Convert.ToInt32(Console.ReadLine());
// bool tempfindNumber = false;
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {

//         Console.Write(myArray[i, j] + "\t");

//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         if (findNumber == myArray[i, j])
//         {
//             tempfindNumber = true;
//             break;
//         }
//     }
// }
// Console.WriteLine(tempfindNumber);


// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// int[,] myArray = new int[,]
// {
//     {1,4,7,2},
//     {5,9,2,3},
//     {8,4,2,4}
// };

// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         Console.Write(myArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < myArray.GetLength(1); j++)
// {
//     double Arifmeticsum = 0;
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         Arifmeticsum += myArray[i, j];
//     }
//     Console.Write(Math.Round(Arifmeticsum / myArray.GetLength(0), 1) + "\t");
// }
