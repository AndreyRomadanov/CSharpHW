// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


distbetwtwopoints(); // Применяем метод.Решаем задачу.

void distbetwtwopoints() // Метод. Ввод данных , решение задачи.
{
    double b1 = promt(" Введите значение b1 первой точки   :    ");
    double k1 = promt(" Введите значение k1 первой точки   :    ");
    double b2 = promt(" Введите значение b2 второй точки   :    ");
    double k2 = promt(" Введите значение k2 второй точки   :    ");
    FindtraightLine(b1, k1, b2, k2);
}

int promt(string message) // Метод. Просим ввести значение,запоминаем.
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FindtraightLine(double b, double k, double a, double c) // Решаем уравнение.
{
    double x = (a - b) / (k - c);
    double y = k * x + b;
    Console.WriteLine($" Точка пересечения заданных прямых   :  X =  {x}  ,  Y =  {y} ");
}
