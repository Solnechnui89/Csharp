// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// int rows = 3; //строки
// int columns = 4; // колонки
// int[,] myArray =
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
// int[] tempMyArray = new int[columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         tempMyArray[j] = myArray[i, j];
//     }
//     Array.Sort(tempMyArray);

//     for (int j = 0; j < columns; j++)
//     {
//         myArray[i, j] = tempMyArray[j];
//     }
// }
// Console.WriteLine("--------------");

// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         Console.Write(myArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] myArray = new int[,]
// {
//     {1,4,7,2},
//     {5,9,2,3},
//     {8,4,2,4},
//     {5,2,6,7}
// };
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         Console.Write(myArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// int minRowSum = int.MaxValue, indexMinRow = 0;
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     int rowSum = 0;
//     for (int j = 0; j <myArray.GetLength(1); j++)
//         rowSum += myArray[i, j];
//     if (rowSum < minRowSum)
//     {
//         minRowSum = rowSum;
//         indexMinRow = i;
//     }
// }
// Console.WriteLine("Строка с минимальной суммой элементов");
// for (int j = 0; j < myArray.GetLength(1); j++)
//     Console.Write(myArray[indexMinRow, j] + "\t");

// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// int rows = 4;
// int columns = 4;
// int[,] myArrayOne = new int[,]
// {
//    {1,4,7,2},
//    {5,9,2,3},
//    {8,4,2,4},
//    {5,2,6,7}
// };

// int[,] myArrayTwo = new int[,]
// {
//     {1,5,8,5},
//     {4,9,4,2},
//     {7,2,2,6},
//     {2,3,4,7}
// };
// int[,] myArrayResult = new int[rows, columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         myArrayResult[i, j] = myArrayOne[i, j] * myArrayTwo[i, j];
//     }
// }
// void writemyArray(int rows, int columns, int[,] matrix)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("MATRIX_ONE");
// writemyArray(rows, columns, myArrayOne);
// Console.WriteLine("MATRIX_TWO");
// writemyArray(rows, columns, myArrayTwo);

// Console.WriteLine("MATRIX_RESULT");
// writemyArray(rows, columns, myArrayResult);

//БЕЗ ЗАДАННЫХ МАТРИЦ:
// int rows = 4;
// int columns = 4;

// rows = new Random().Next(4, 5);
// columns = new Random().Next(4, 5);

// int[,] myArrayOne = new int[rows, columns];
// int[,] myArrayTwo = new int[rows, columns];
// int[,] myArrayResult = new int[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         myArrayOne[i, j] = new Random().Next(1, 10);
//         myArrayTwo[i, j] = new Random().Next(1, 8);
//         myArrayResult[i, j] = myArrayOne[i, j] * myArrayTwo[i, j];
//     }
// }
// void writemyArray(int rows, int columns, int[,] matrix)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("MATRIX_ONE");
// writemyArray(rows, columns, myArrayOne);
// Console.WriteLine("MATRIX_TWO");
// writemyArray(rows, columns, myArrayTwo);

// Console.WriteLine("MATRIX_RESULT");
// writemyArray(rows, columns, myArrayResult);

// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int firstSize = 2;
int seconsSize = 2;
int thirdSize = 2;

int step = 4;
int minRandom = 0;
int maxRandom = step;

int[,,] array = new int[firstSize, seconsSize, thirdSize];
for (int i = 0; i < firstSize; i++)
{
    for (int j = 0; j < seconsSize; j++)
    {
        for (int k = 0; k < thirdSize; k++)
        {
            array[i, j, k] = new Random().Next(minRandom, maxRandom);
            minRandom += step;
            maxRandom += step;
            Console.Write(array[i, j, k] + "/t");
        }
        Console.Write("\t");
    }
    Console.WriteLine("\n");
}
for (int i = 0; i < firstSize; i++)
{
    for (int j = 0; j < seconsSize; j++)
    {
        for (int k = 0; k < thirdSize; k++)
        {
            Console.WriteLine($"{array[i, j, k]}\t[{i},{j},{k}]");
        }
    }
}


