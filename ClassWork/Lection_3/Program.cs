//Виды методов в программировании:
//1.НЕ принимает и НЕ возвращает аргументы:
// void Method1()
// {
//     Console.WriteLine("Автор..");
// }
// Method1();

//2. ЧТО-ТО принимает, НИЧЕГО не возвращает(void):
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения ");

//Если нужно повторить слово 4 раза,например:
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);

//3.НИЧЕГО не принимает, ЧТО-ТО возвращает:
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
// Console.WriteLine(Year);

//4.ЧТО-ТО принимает, Что-то возвращает:
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

//ЦИКЛ "FOR"
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

//ЦИКЛ в ЦИКЛЕ (Выводим таблицу умножения)
// for(int i=2; i<10; i++)
// {
//     for(int j=2; j<10;j++)
//     {
//         Console.WriteLine($"{i}*{j}={i*j}");
//     }
//     Console.WriteLine();
// }

// ЗАДАЧА:
// Дан текст.В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" → маленькие "c"

// string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы Вас послали вместо нашего милого Винценгроде,"
//             + "Вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
//string s="qwerty"
//            0 1 2...
//s[3]-r
// string Replace(string text, char oldValue, char newValue) //заменить в тексте старый на новый
// {
//     string result = String.Empty; //инициализация пустой строки
//     int Length = text.Length; //кол-во символов в строке
//     for (int i = 0; i < Length; i++) // пробигаемся от 0 символа до конца длины строки
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

//УПОРЯДОЧИТЬ МАССИВ:
//Алгоритм сортировки методом выбора
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array) //метод упорядовавший наш массив
// {
//     for (int i = 0; i < array.Length - 1; i++) //пробегаемся по всем эл-ам массива.(искусственно -1, если мы начинаем поиск max с индекса i+1(стр124), где i меняется до max знач позиции array.Length)
//     {
//         int minPosition = i; //та позиция эл-та д,которой мы будем производить последов-ть действий
//         for (int j = i + 1; j < array.Length; j++) //i+1 даст общее кол-во эл-ов
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i]; //замена найденой позиции с изначальной
//         array[i] = array[minPosition]; //в i-ую позицию нужно положить тот эл-т,кот б найден в процессе с 124по 130строку
//         array[minPosition] = temporary;//в него кладем тот элемент,который был временным
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array) //метод упорядовавший наш массив
// {
//     for (int i = 0; i < array.Length + 1; i++) //пробегаемся по всем эл-ам массива.(искусственно -1, если мы начинаем поиск max с индекса i+1(стр124), где i меняется до max знач позиции array.Length)
//     {
//         int maxPosition = i; //та позиция эл-та д,которой мы будем производить последов-ть действий
//         for (int j = i + 1; j > array.Length; j++) //i+1 даст общее кол-во эл-ов
//         {
//             if (array[j] > array[maxPosition])
//             {
//                 maxPosition = i;
//             }
//         }
//         int temporary = array[i]; //замена найденой позиции с изначальной
//         array[i] = array[maxPosition]; //в i-ую позицию нужно положить тот эл-т,кот б найден в процессе с 124по 130строку
//         array[maxPosition] = temporary;//в него кладем тот элемент,который был временным
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


//Двумерные массивы:
// int [,]matrix=new int[5,8];
// string[,]table=new string[2,5]; //table[0,0]-1 столбик,1 строки table[0,1]-2 столбик, 1 строки...table[0,4] 4столб,1строки
// table[1,2]="слово ";            //table[1,0]-1 столбик,2 строки table[1,1]-2 столбик,2 строки ...table[4,4] 4столб 2 строки
// for(int rows=0; rows<2; rows++)
// {
//     for(int columns=0; columns<5;columns++)
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }

 int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]}");
//     }
//     Console.WriteLine();
// }


//  void PrintArray(int[,], matr)
//  {
//      for (int i = 0; i < matr.GetLength(0); i++)
//      {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i, j]}");
//          }
//          Console.WriteLine();
//      }
//  }
//  void FillArray(int[,] matr)
//  {
//      for (int i = 0; i < matr.GetLength(0); i++)
//      {
//          for (int j = 0; j < matr.GetLength(1); j++)
//          {
//              matr[i, j] = new Random().Next(1, 10); //[1;10)
//          }
//      }
//  }
//  int[,] matrix = new int[3, 4];
//  PrintArray(matrix);
//  FillArray(matrix) < Console.WriteLine();
//  PrintArray(matrix);


//КАК ПРЕДСТАВИТЬ ЧЕРНО-БЕЛОЕ ИЗОБРАЖЕНИЕ:
//  void PrintImage(int[,], image)
// {
// for (int i = 0; i < image.GetLength(0); i++)
//  {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//            if (image[i, j] == 0) Console.Write($" ");
//           else (Console.Write($"+"));
//         }
//      }
// }
//  PrintImage(pic);
