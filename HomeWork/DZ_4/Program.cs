// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень первого числа: ");
int stepenNumber = Convert.ToInt32(Console.ReadLine());
int count=Convert.ToInt16(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Итого = " + Math.Pow(firstNumber, stepenNumber));
}

// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= Number; i++)
// {
//      sum = sum + Number % 10;
//      Number = Number / 10;
// }
// Console.WriteLine(sum);

// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] myArray=new int[8];
// for(int i=0; i<myArray.Length;i++) 
// {
//     Console.WriteLine($"\nВведите элемент массива под индексом: {i}");
//     myArray[i]= int.Parse(Console.ReadLine());
// }
// Console.WriteLine($"[{String.Join("; ", myArray)}]");
