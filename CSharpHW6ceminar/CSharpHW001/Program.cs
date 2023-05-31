// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


NumbersArray ( ) ;                                                 // Решаем задачу.

void NumbersArray ( )                                               // Определяем количество в массиве чисел больше 0.
{
int[] NumbersArray =  BildSizeBodyArray ( ) ; 
int even = 0 ;
for ( int i = 0 ; i < NumbersArray.Length ; i ++ )
{
if ( NumbersArray [ i ]  > 0 ) 
{
     Console.WriteLine ( $"   Число   { NumbersArray [ i ]  }   - бщльше 0.   " ) ;
     even ++ ;
}
else 
{
     Console.WriteLine ( $"   Число   { NumbersArray [ i ]  }   - меньше иои равно 0.   " ) ; 
} 
}
Console.WriteLine ( $" Количество чисел больше 0  =   { even } " ) ;
}

int[] BildSizeBodyArray ( )                                       // Задаём параметры массива .
{
int min = -100;
int max = 100 ;
Console.Write ( " Введите  количество чисел в массиве M :  ") ;
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
     Console.WriteLine ( $" Создаём массив случайных чисел   [ { String.Join ( " " , arr ) } ] " ) ;
    return arr ;
}