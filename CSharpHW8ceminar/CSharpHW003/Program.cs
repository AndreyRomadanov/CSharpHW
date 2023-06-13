// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


BodyBildArray ( ) ;                                                                // Запускаем программу.

void BodyBildArray ( )                                                             // Вводим параметры массива.
{
    Console.Write ( " Введите  количество строк второго и столбцов первого массива  :  " ) ;
    int rowscolumns = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  количество строк первого  массива  :  " ) ;
    int rows = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  количество столбцов второго массива  :  " ) ;
    int columns = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  минимально допустимое заначение массива  :  " ) ;
    int minVal = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите  максимально допустимое заначение массива  :  " ) ;
    int maxVal = int.Parse ( Console.ReadLine ( ) ! ) ;
    int [ , ] array1 = GetArray ( rows , rowscolumns , minVal , maxVal ) ;
    Console.WriteLine ( " Двумерный массив : " ) ;
    PrintArray ( array1 ) ;
    int [ , ] array2 = GetArray ( rowscolumns , columns , minVal , maxVal ) ;
    Console.WriteLine ( " Умножаем на двумерный массив : " ) ;
    PrintArray ( array2 ) ;
    int[ , ] result = MultiplyArrayByArrayOne ( rows , columns , rowscolumns , array1 , array2 ) ;
    Console.WriteLine ( " Получаем результат задачи  : " ) ;
    PrintArray ( result ) ;
}

int [ , ] GetArray ( int m , int n , int minValue , int maxValue )                // Заполняем массив числами.
{
    int [ , ] newarr = new int [ m , n ] ;
    for ( int i = 0 ; i < m ; i++ )
    {
        for ( int j = 0 ; j < n ; j ++ )
        {
            newarr [ i , j ] = new Random ( ) .Next ( minValue , maxValue + 1 ) ;
        }
    }
    return newarr ;
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

int[ , ] MultiplyArrayByArrayOne ( int x , int y , int z , int [ , ] inArr1 , int [ , ] inArr2 )     // Перемножаем матрицы.                                       
{
int i = 0;
int j = 0 ;
int[ , ] res = new int [ x , y ] ;
for ( i = 0 ; i < x ; i ++) 
{
     for ( j = 0 ; j < y ; j ++)
    {
         for ( int k = 0 ; k < z ; k ++) 
        {
            res [ i , j ] += inArr1 [ i , k ]  *  inArr2 [ k , j ] ;
        }
    }
}
return res ;
}