// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


SummaNotEvenNumbersArray ( ) ;                                        // Решаем задачу.

void SummaNotEvenNumbersArray ( )                                     // Определяем не чётные в массиве числа и их сумму.
{
int[] NumbersArray =  BildSizeBodyArray ( ) ; 
int Summa = 0 ;
for ( int i = 0 ; i < NumbersArray.Length ; i ++ )
{
if ( NumbersArray [ i ]  %  2  ==  0 ) 
{
     Console.WriteLine ( $"   Число   { NumbersArray [ i ]  }   - чётное.   " ) ;
}
else 
{
     Console.WriteLine ( $"   Число   { NumbersArray [ i ]  }   - не чётное.   " ) ; 
     Summa = Summa + NumbersArray [ i ] ;
} 
}
Console.WriteLine ( $" Сумма не чётных чисел в массиве =   { Summa } " ) ;
}

int[] BildSizeBodyArray ( )                                                // Задаём параметры массива .
{
Console.Write ( " Введите  минимально допустимое заначение массива  :  ") ;
int min = int.Parse ( Console.ReadLine ()! ) ;
Console.Write ( " Введите  максимально допустимое заначение массива  :  ") ;
int max = int.Parse ( Console.ReadLine ()! ) ;
if ( min > max )
{
  Console.WriteLine ( " Вы ввели недопустимые значения. Минимальное значение не может быть больше максимального. Введите другие значения.") ;
   return BildSizeBodyArray ( ) ;
}
Console.Write ( " Введите  количество чисел в массиве  :  ") ;
int realsize = int.Parse ( Console.ReadLine ()! ) ;
int[] array = BildArray  (  min ,  max , realsize ) ; 
return array ;
}

int[] BildArray  ( int minValue , int maxValue , int tipeSize )             // Создаём массив случайных чисел.
{
    int[] arr = new int [ tipeSize ] ;
    for ( int i = 0 ; i < tipeSize ; i ++ )
    {
        arr [ i ] = new Random().Next( minValue , maxValue + 1 ) ;
    }
     Console.WriteLine ( $" Создаём массив случайных чисел   [ { String.Join ( " " , arr ) } ] " ) ;
    return arr ;
}