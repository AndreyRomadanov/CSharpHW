// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


DifferenceBetweenMaxMinValue ( ) ;                  // Решаем задачу.

void DifferenceBetweenMaxMinValue ( )               // Ищем минимальное и максимальное число в массиве , вычисляем разницу.
{
double[] ArrayRealValue = BildSizeBodyArray ( ) ;
double max = 0 ;  
for ( int i = 0 ; i < ArrayRealValue.Length ; i ++ )
{
if ( ArrayRealValue [ i ] > max )
{
    max = ArrayRealValue [ i ] ;
}
}
double min = max ;
for ( int i = 0 ; i < ArrayRealValue.Length ; i ++ ) 
{
if ( ArrayRealValue [ i ] < min )
{
    min = ArrayRealValue [ i ] ;
}
}
Console.WriteLine ( $" Вычисляем максимальное   :  { max } , и минимальное   :  { min }  числа в массиве.") ;
Console.WriteLine ( $" Вычисляем разницу между максимальным и минимальным числом в массиве  :  { Math.Round ( ( max - min ) , 2 ) }.") ;
}

double[] BildSizeBodyArray ( )                                                // Задаём параметры массива .
{
Console.Write ( " Введите  минимально допустимое заначение массива  :  ") ;
int minVal = int.Parse ( Console.ReadLine ()! ) ;
Console.Write ( " Введите  максимально допустимое заначение массива  :  ") ;
int maxVal = int.Parse ( Console.ReadLine ()! ) ;
if ( minVal > maxVal )
{
  Console.WriteLine ( " Вы ввели недопустимые значения. Минимальное значение не может быть больше максимального. Введите другие значения.") ;
   return BildSizeBodyArray ( ) ;
}
Console.Write ( " Введите  количество чисел в массиве  :  ") ;
int realsize = int.Parse ( Console.ReadLine ()! ) ;
double[] array =  ArrayRealNumbers (  minVal ,  maxVal , realsize ) ; 
return array ;
}

double[] ArrayRealNumbers  ( int minValue , int maxValue , int tipeSize )       // Создаём массива из вещественных чисел.       // Создаём массив случайных чисел.
{
    double[] arr = new double [ tipeSize ] ;
    for ( int i = 0 ; i < tipeSize ; i ++ )
    {
        arr [ i ] = Math.Round ( new Random ( ).NextDouble ( ) , 2 )   + new Random ( ).Next (  minValue ,  maxValue + 1 ) ;
    }
     Console.WriteLine ( $" Создаём массив случайных вещественных чисел  : [ { String.Join ( "  " , arr ) } ] " ) ;
    return arr ;
}