// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
//6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9


int[] RandomArray ( int num )                    // Задаём массив.
{
    int[] array = new int [ num ] ;
    for ( int i = 0 ; i < num ; i ++ )
    {
        array [ i ] = new Random().Next (100) ;
    }
    return array ; 
}

void PrintArray ( int[] array )                  // Выводим на экран.
{
   for ( int i = 0 ; i < array.Length ; i ++ )
    {
       Console.Write ( $"[{ array [ i ]}]" ) ;
    }
   Console.WriteLine( ) ; 
}

void Go ( )                                      // Запуск методов.
{
int Length = 8 ;
int[] arr = RandomArray ( Length ) ;
PrintArray (  arr ) ;
}

Go ( ) ;                                         // Запуск программы.