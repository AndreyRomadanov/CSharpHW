//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

distbetwtwopoints ( ) ;                                                              //Применяем метод.Решаем задачу.

void distbetwtwopoints ( )                                                           // Метод. Ввод данных , решение задачи.
{
int xa1 = promt ( " Введите координату x первой точки   :  " ) ;
int ya1 = promt ( " Введите координату y первой точки   :  " ) ;
int za1 = promt ( " Введите координату z первой точки   :  " ) ;
int xb1 = promt ( " Введите координату x второй точки   :  " ) ;
int yb1 = promt ( " Введите координату y второй точки   :  " ) ;
int zb1 = promt ( " Введите координату z второй точки   :  " ) ;
distancebetweentwopoints ( xa1 , xb1 , ya1 , yb1 , za1 , zb1 ) ;
}

int promt ( string message )                                                          // Метод. Ввод данных.
{ 
Console.Write ( message) ;
int number = int.Parse ( Console.ReadLine () ! ) ;
return number ;
} 

void distancebetweentwopoints ( int xa , int xb , int ya , int yb , int za , int zb ) // Метод. Решение задачи.
{
double AB = Convert.ToDouble ( Math.Round ( Math.Sqrt ( Math.Pow ( ( xb - xa ) , 2 ) + Math.Pow ( ( yb - ya ) , 2 ) + Math.Pow ( ( zb - za ) , 2 ) ) , 2 ) ) ;
Console.WriteLine ( " Расстояние между двумя точками  :  " + AB ) ;
}
