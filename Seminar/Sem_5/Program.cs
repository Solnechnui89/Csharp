// Задача 31: Задайте массив из 12 элементов, заполненный 
//случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных 
//и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];

// int size = array.Length;

// int resultPositive = 0;

// int resultNegative = 0;

// int index = 0;

// while (index < size) 
// {
//     array[index] = new Random().Next(-9,10); // [-9;10)
//     index++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// for (int startIndex = 0; startIndex < size; startIndex++)
// {
//     if (array[startIndex] > 0) 
//     {
//         resultPositive += array[startIndex];
//         //resultPositive=resultPositive +  array[startIndex]
//     }
//     else 
//     {
//         resultNegative += array[startIndex];
//     }
// }


// Console.WriteLine($"Сумма положительных чисел = {resultPositive}");
// Console.WriteLine($"Сумма отрицательных чисел = {resultNegative}");


// for (int i = 0; i < n; i++)   
//  {                 
//     if (x[i] != chislo) 
//      {                 
//         Console.WriteLine("Такого числа нет!!!");
//         Console.ReadKey();  
//         return;  
//     }    
//  }  