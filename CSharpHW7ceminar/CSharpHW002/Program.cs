// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


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
    FindNumderArray(rows, columns, array);
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

int FindNumderArray(int m, int n, int[,] res) // Ищем число по введённым координатам.
{
    Console.Write(" Введите строку искомого числа в массиве  :  ");
    int ifind = int.Parse(Console.ReadLine()!);
    Console.Write(" Введите столбец искомого числа в массиве  :  ");
    int jfind = int.Parse(Console.ReadLine()!);
    int sum = 0;
    bool flag = false;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == ifind && j == jfind)
            {
                Console.Write($" {res[i, j]} ");
                flag = true;
            }
            else
            {
                Console.Write($" {"X"} ");
            }
        }
        Console.WriteLine(" ");
    }
    if (flag == false)
    {
        Console.WriteLine(" Значений по этим координатам в данном массиве нет.");
    }
    return sum;
}
