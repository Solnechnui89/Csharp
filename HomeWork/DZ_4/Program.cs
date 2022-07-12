// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень для первого числа: ");
int stepenNumber = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("ИТОГО= " + Math.Pow(firstNumber, stepenNumber));
   break;
}






// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int firstNumber = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; 1 <= firstNumber; i++)
// {
//     sum+= i;
// }
// Console.WriteLine(sum);


// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]