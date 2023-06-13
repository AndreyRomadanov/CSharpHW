// Задача 60. ***...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

BodyBildArray ( ) ;                                                                // Запускаем программу.

void BodyBildArray ( )                                                             // Вводим параметры массива.
{
    Console.Write ( " Введите  количество листов трёхмерного массива  :  " ) ;
    int page = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  количество строк трёхмерного массива  :  " ) ;
    int rows = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  количество столбцов трёхмерного массива  :  " ) ;
    int columns = int.Parse ( Console.ReadLine ( ) ! ) ;
    int minVal = 10 ;
    int maxVal = 99 ;
    int [ , , ] array = GetArray ( page , rows , columns , minVal , maxVal ) ;
    Console.WriteLine ( " Получили трёхмерный  массив : " ) ;
    PrintArray ( array ) ;
}

int [ , , ] GetArray ( int p , int m , int n , int minValue , int maxValue )                // Заполняем массив числами.
{
    int [ , , ] newarr = new int [ p , m , n ] ;
    for ( int k = 0 ; k < p ; k ++ )        
    {
        for ( int i = 0 ; i < m ; i ++ )
        {
            for ( int j = 0 ; j < n ; j++ )
            {
                newarr [ k , i , j ] = new Random ( ) .Next ( minValue , maxValue + 1 ) ;
            }
        }      
    }
  return newarr ;
}

void PrintArray ( int [ , , ] inArray )                                            // Выводим на экран что получилось.
{
    for ( int k = 0 ; k < inArray.GetLength ( 0 ) ; k ++ ) 
    {  
       Console.WriteLine ( $" Страница № { k + 1 }") ; 
       for ( int i = 0 ; i < inArray.GetLength ( 1 ) ; i ++ )
       {
           for ( int j = 0 ; j < inArray.GetLength ( 2 ) ; j++ )
           {
               Console.Write ( $"   { inArray [ k , i , j ] }  ( {k } , { i } , { j } )   " ) ;
           }
        Console.WriteLine ( " " ) ;
       }
    }
}