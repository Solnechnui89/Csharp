// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int fivenumber = Convert.ToInt32(Console.ReadLine());
// int one = (fivenumber/10000);
// int two = (fivenumber/1000)%10;
// int three =(fivenumber/100)%10;
// int four = (fivenumber/10)%10;
// int five = (fivenumber%10);
// Console.WriteLine($"1-{one} 2-{two} 3{three} 4{four} 5{five}");
// if(one==five && two==four)
// {
//     Console.WriteLine("Это палиндром! ");
// }
// else
// {
//     Console.WriteLine("Это не палиндром...");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=N; i++)
{
    Console.WriteLine($"Куб числа {i} = {i*i*i}");
}