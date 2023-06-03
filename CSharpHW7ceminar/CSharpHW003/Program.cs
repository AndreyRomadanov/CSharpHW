// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


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
    int[,] array = GetArray(rows, columns, minVal, maxVal);
    PrintArray(array);
    SumNumbaColAr(rows, columns, array);
}

int[,] GetArray(int m, int n, int minValue, int maxValue) // Заполняем массив числами.
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // Выводим на экран что получилось.
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

double SumNumbaColAr(int m, int n, int[,] colArray) // Считаем среднеие арифметические значения в столбцах.
{
    double summa = 0;
    for (int j = 0; j < n; j++)
    {
        summa = 0;
        for (int i = 0; i < m; i++)
        {
            summa = summa + colArray[i, j];
        }
        summa = Math.Round(summa / m, 2);
        Console.WriteLine($" Среднее арифметическое {j + 1} столбца  =  {summa}  ");
    }
    return summa;
}
