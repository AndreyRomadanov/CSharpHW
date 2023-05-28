// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


NumberEvenNumbersArray ( ) ;                                        // Решаем задачу.

void NumberEvenNumbersArray ( )                                     // Определяем чётные числа и их количество в массиве.
{
int[] NumbersArray =  BildSizeBodyArray ( ) ; 
int even = 0 ;
for ( int i = 0 ; i < NumbersArray.Length ; i ++ )
{
if ( NumbersArray [ i ]  %  2  ==  0 ) 
{
     Console.WriteLine ( $"   Число   { NumbersArray [ i ]  }   - чётное.   " ) ;
     even ++ ;
}
else 
{
     Console.WriteLine ( $"   Число   { NumbersArray [ i ]  }   - не чётное.   " ) ; 
} 
}
Console.WriteLine ( $" Количество чётных чисел  =   { even } " ) ;
}

int[] BildSizeBodyArray ( )                                       // Задаём параметры массива .
{
int min = 100 ;
int max = 999 ;
Console.Write ( " Введите  количество чисел в массиве  :  ") ;
int realsize = int.Parse ( Console.ReadLine ()! ) ;
int[] array = BildArray  (  min ,  max , realsize ) ; 
return array ;
}

int[] BildArray ( int minValue , int maxValue , int tipeSize )    // Создаём массив случайных чисел.
{
    int[] arr = new int [ tipeSize ] ;
    for ( int i = 0 ; i < tipeSize ; i ++ )
    {
        arr [ i ] = new Random().Next( minValue , maxValue + 1 ) ;
    }
     Console.WriteLine ( $" Создаём массив случайных трёхзначных чисел   [ { String.Join ( " " , arr ) } ] " ) ;
    return arr ;
}