// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] myArray = new int[5];
// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"Введите число массива с индексом[{i}] = ");
//     myArray[i] = int.Parse(Console.ReadLine());
// }
// uint resultPositiveNumbersM = 0; //четные числа
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//     {
//         resultPositiveNumbersM++;
//     }
// }
// Console.WriteLine($"Общее количество чётных чисел в массиве: " + resultPositiveNumbersM);


// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1");
double NumberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1");
double NumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2");
double NumberThree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
double NumberFour = Convert.ToInt32(Console.ReadLine());

double X = (NumberThree-NumberFirst)/(NumberTwo-NumberFour);
double Y = NumberTwo*(NumberThree-NumberFirst)/(NumberTwo-NumberFour)+NumberFirst;

Console.WriteLine(X);
Console.WriteLine(Y);
