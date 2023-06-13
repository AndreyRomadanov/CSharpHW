// Задача 62 *** Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


BodyBildArray ( ) ;                                                                // Запускаем программу.

void BodyBildArray ( )                                                             // Вводим параметры массива.
{
    Console.Write ( " Введите  количество строк первого  массива  :  " ) ;
    int rows = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  количество столбцов второго массива  :  " ) ;
    int columns = int.Parse ( Console.ReadLine ( ) ! ) ;
    int numders = 0 ;
    int [ , ] array = GetArray ( numders ,  rows , columns ) ;
    Console.WriteLine ( " Полученный двумерный массив : " ) ;
    PrintArray ( array  ) ;
}

int [ , ] GetArray ( int numder ,  int m , int n )                                 // Заполняем массив числами по спирали.
{
  int i = 0 ;
  int j = 0 ;
  int k = 0 ;
int [ , ] result = new int [ m , n ] ;
while ( k < ( m + n ) / 3 + 1 )
{ 
  n = n - 1 ;
  m = m - 1 ;
        while (  j < n )
      { 
        result [ i , j ] = numder + 1 ; 
        numder = result [ i , j ]  ;
        j++;
      }
        while (  i < m )
      { 
        result [ i , j ] = numder + 1 ; 
        numder = result [ i , j ]  ;
        i++;
      }  
        while (  j > k )
      { 
        result [ i , j ] = numder + 1 ; 
        numder = result [ i , j ]  ;
        j--;
      }
        while (  i > k )
      { 
         result [ i , j ] = numder + 1 ; 
         numder = result [ i , j ]  ; 
         i--;                       
      }      
  i = i + 1 ;
  j = j + 1 ;
  k = k + 1 ;
}  
 return result ;
}

void PrintArray ( int [ , ] inArray  )                             // Выводим на экран что получилось.
{
    for ( int i = 0 ; i < inArray.GetLength ( 0 ) ; i ++ )
    {
        for ( int j = 0 ; j < inArray.GetLength ( 1 ) ; j++ )
        {
          if (inArray [ i , j ] < 10 )
           {  Console.Write ( $" { 0 }{ inArray [ i , j ] }  ") ;}
          else
           {  Console.Write ( $" { inArray [ i , j ] }  " ) ; }
        }
        Console.WriteLine ( " " ) ;
    }
}