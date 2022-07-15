// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] myArray = new int[4];
// int sizeArray = myArray.Length;
// int amountOfEvenNumbers = 0;
// for (int i = 0; i < sizeArray; i++)
// {
//     Console.Write($"Введите элемент массива {i}: ");
//     myArray[i] = int.Parse(Console.ReadLine());
//     if (myArray[i] % 2 == 0)
//         amountOfEvenNumbers++;
// }
// Console.WriteLine(amountOfEvenNumbers);

// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] myArray = new int[4];
// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"Введите число массива с индексом[{i}] = ");
//       myArray[i] = int.Parse(Console.ReadLine());
// }
// int SumOddElements = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (i % 2 != 0)

//         SumOddElements += myArray[i];
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {SumOddElements}");

// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] myArray = new double[5];
// int sizeArray = myArray.Length;
// for (int i = 0; i < sizeArray; i++)
// {
//     Console.Write($"Введите элемент массива {i}: ");
//     myArray[i] = Convert.ToDouble(Console.ReadLine());
// }
// double minArrayElement = myArray[0];
// for (int i = 1; i < sizeArray; i++)
// {
//     if (minArrayElement > myArray[i])
//         minArrayElement = myArray[i];
// }
// Console.WriteLine("minArrayElement = {0}", minArrayElement);

// double maxArrayElement = myArray[0];
// for (int i = 1; i < sizeArray; i++)
// {
//     if (maxArrayElement < myArray[i])
//         maxArrayElement = myArray[i];
// }
// Console.WriteLine("maxArrayElement = {0}", maxArrayElement);
// Console.WriteLine("Разница между максимальным и минимальным элементами массива: {0}", maxArrayElement - minArrayElement);

