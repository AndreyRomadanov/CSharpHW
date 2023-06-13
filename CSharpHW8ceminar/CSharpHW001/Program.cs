// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
    int [ , ] arraSortingNumbery = SortingNumbersDescendingOrder ( array ) ;
    Console.WriteLine ( " распределяем числа в строках от большего к меньшему : " ) ;
    PrintArray ( arraSortingNumbery ) ;
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

int [ , ]  SortingNumbersDescendingOrder ( int [ , ]  colArray )                // Распределяем числа в строках на убывание.
{
   for ( int i = 0 ; i < colArray.GetLength ( 0 ) ; i ++ )
    {
       for ( int j = 0 ; j < colArray.GetLength ( 1 ) - 1  ; j ++ )
        {
           for ( int n = 0 ;  n < colArray.GetLength ( 1 ) - 1   ; n ++ )
            {
                if ( colArray [ i , n ] < colArray [ i , n + 1 ] )
                {
                    int temp = colArray [ i , n ] ;
                    colArray [ i , n ] = colArray [ i , n + 1 ] ;
                    colArray [ i , n + 1 ] = temp ;
                }
            }
        }
    }
    return colArray;
}