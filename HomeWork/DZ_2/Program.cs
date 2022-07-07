//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// string digitTwo = Console.ReadLine();
// Console.WriteLine("Второе число из 3-значного числа: " + digitTwo[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = Convert.ToInt32(Console.ReadLine());
string numtext = Convert.ToString(num);
if(numtext.Length>2)
{
    Console.WriteLine("Третья цифра: " + numtext[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет ");
}