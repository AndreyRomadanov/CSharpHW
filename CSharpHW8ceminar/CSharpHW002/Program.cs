// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


BodyBildArray ( ) ;                                                                // Запускаем программу.

void BodyBildArray ( )                                                             // Вводим параметры массива.
{
    Console.Write ( " Введите  количество строк  массива  :  " ) ;
    int rows = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  количество столбцов  массива  :  " ) ;
    int columns = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  минимально допустимое заначение массива  :  " ) ;
    int minVal = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  максимально допустимое заначение массива  :  " ) ;
    int maxVal = int.Parse ( Console.ReadLine ( ) ! ) ;
    int [ , ] array = GetArray ( rows , columns , minVal , maxVal ) ;
    Console.WriteLine ( " Полученный двумерный массив : " ) ;
    PrintArray ( array ) ;
    int minstring = SumRowsArray  ( maxVal , columns , array )  ;
    Console.WriteLine ( $" Если считать сумму чисел в строках , то в данном массиве она будет минимальна в { minstring } строке." ) ;
}

int [ , ] GetArray ( int m , int n , int minValue , int maxValue )                // Заполняем массив числами.
{
    int [ , ] result = new int [ m , n ] ;
    for ( int i = 0 ; i < m ; i++ )
    {
        for ( int j = 0 ; j < n ; j ++ )
        {
            result [ i , j ] = new Random ( ) .Next ( minValue , maxValue + 1 ) ;
        }
    }
    return result ;
}

void PrintArray ( int [ , ] inArray )                                            // Выводим на экран что получилось.
{
    for ( int i = 0 ; i < inArray.GetLength ( 0 ) ; i ++ )
    {
        for ( int j = 0 ; j < inArray.GetLength ( 1 ) ; j++ )
        {
            Console.Write ( $" { inArray [ i , j ] }  " ) ;
        }
        Console.WriteLine ( " " ) ;
    }
}

int  SumRowsArray  ( int value , int count , int[ , ]  colArray )      // Считаем сумму в строках.,возвращаем номер строки с минимальной суммой.
{
  int minstr = 0 ;
  int summin = value * count ;
 for ( int i = 0 ; i < colArray.GetLength ( 0 ) ; i ++ )
    {  
       int sum = 0;
       for ( int j = 0 ; j < colArray.GetLength ( 1 )   ; j ++ )
            {
               sum  = colArray [ i , j ] + sum ;          
            }  
       if (  summin > sum ) 
            {
               summin = sum  ;
               minstr = i + 1 ;
            }
    }   
return minstr ;
}