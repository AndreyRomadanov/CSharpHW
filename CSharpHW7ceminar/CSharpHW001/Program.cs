﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


BodyBildArray(); // Запускаем программу.

void BodyBildArray() // Вводим параметры массива.
{
    Console.Write(" Введите  количество строк  массива  :  ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write(" Введите  количество столбцов  массива  :  ");
    int columns = int.Parse(Console.ReadLine()!);
    Console.Write(" Введите  минимально допустимое заначение массива  :  ");
    int minVal = int.Parse(Console.ReadLine()!);
    Console.Write(" Введите  максимально допустимое заначение массива  :  ");
    int maxVal = int.Parse(Console.ReadLine()!);
    double[,] array = GetArray(rows, columns, minVal, maxVal);
    PrintArray(array);
}

double[,] GetArray(int m, int n, int minValue, int maxValue) // Заполняем массив числами.
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] =
                Math.Round(new Random().NextDouble(), 2)
                + new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray) // Выводим на экран что получилось.
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}
