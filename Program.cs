// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Введите количество строк массива: ");
// var m = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// var n = int.Parse(Console.ReadLine());

// double[,] array = GetRandomArray(m, n, 10, 100);

// double[,] GetRandomArray(int m, int n, int minValue, int maxValue)
// {
//     var rnd = new Random();
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//            result[i, j] = rnd.Next(minValue, maxValue) + Math.Round(rnd.NextDouble(), 1);
//         }
//     }
//     return result;
// }
// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// PrintArray(array);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк массива: ");
// var row = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// var columns = int.Parse(Console.ReadLine());
// var minval = 1;
// var maxval = 10;

// int[,] array = GetRandomArray(row, columns, minval, maxval);

// int[,] GetRandomArray(int row, int columns, int minValue, int maxValue)
// {
//     var rnd = new Random();
//     int[,] result = new int[row, columns];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//            result[i, j] = rnd.Next(minValue, maxValue);
//         }
//     }
//     return result;
// }
// Console.WriteLine("Если необходимо найти число - Введите 1");
// Console.WriteLine("Если хотите найти позицию в массиве - Введите 2");
// string enternumber = Console.ReadLine();
// int number = Convert.ToInt32(enternumber);
// switch (number)
// {
//     case 1:
//         Console.Write($"Введите число от {minval} до {maxval - 1} : ");
//         string enterNum = Console.ReadLine();
//         int num = Convert.ToInt32(enterNum);
//         int count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] == num)
//                 {   
//                     count++;
//                     Console.WriteLine($"Данное число {num} находится в {i+1} строке, {j+1} столбце");
//                 }   
//             if (i == (array.GetLength(0) - 1) & j == (array.GetLength(1) - 1) & count == 0)
//                 {
//                     Console.WriteLine($"Данное число {num}, не найдено");
//                 }
//             }
            
//         }
                
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                  Console.Write($"{array[i, j]} ");
//                 }
//             Console.WriteLine();            
//         }
//     break;
//     case 2:
//         Console.Write($"Введите строку: ");
//         string enterNum1 = Console.ReadLine();
//         int num1 = Convert.ToInt32(enterNum1);

//         Console.Write($"Введите столбец: ");
//         string enterNum2 = Console.ReadLine();
//         int num2 = Convert.ToInt32(enterNum2);

//         if (num1 <= array.GetLength(0) & num2 <= array.GetLength(1))
//         {
//             Console.WriteLine($"На данной позиции находиться число - {array[num1 - 1, num2 - 1]}");
            
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     Console.Write($"{array[i, j]} ");
//                 }
//                 Console.WriteLine();            
//             }
//         }
//         else 
//             Console.Write("Такой позиции нет");
//         break;
//     default:
//         Console.WriteLine("Такого варианта нет)");
//     break;
// }





// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк массива: ");
// var row = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// var columns = int.Parse(Console.ReadLine());
// var minval = 1;
// var maxval = 10;

// int[,] array = GetRandomArray(row, columns, minval, maxval);

// int[,] GetRandomArray(int row, int columns, int minValue, int maxValue)
// {
//     Console.WriteLine("Среднее арифметическое каждого столбца");
//     var rnd = new Random();
//     int[,] result = new int[row, columns];
//     for (int j = 0; j < columns; j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < row; i++)
//         {
//            result[i, j] = rnd.Next(minValue, maxValue);
//            sum = sum + result[i, j];
//         }        
//         Console.Write($"<{Math.Round(Convert.ToDouble(sum / row), 1)}> ");
//     }
//     return result;
// }
// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}    ");
//         }
//     Console.WriteLine();            
// }
