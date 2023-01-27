// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();

// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }

Console.Clear();

void FillArray(double [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().NextDouble();
        }
      }
  }
  void PrintArray(double[,] matr) // Создание матрицы 
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]:f2} ");
        }
    Console.WriteLine();
    }
  }
    Console.WriteLine("Введите число (количество строк): ");
    int val1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите число (количество столбцов): ");
    int val2 = Convert.ToInt32(Console.ReadLine());
  double[,] array = new double [val1, val2];
  FillArray(array);
  PrintArray(array);

