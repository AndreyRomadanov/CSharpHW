// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int GenerateRandomNumber ( )                                                        // Генератор сучайного числа.
{
    int rand = new Random ( ).Next (  ) ;                               
    return rand ;
}

int ConvertNumberArray ( int number , int Summma)                                   // Конвертируем число в массив , 
{                                                                                   // складываем числа массива.
    string str = number.ToString () ;
    int[] array = new int [ str. Length ] ;
    for ( int i = 0 ; i < str.Length ; i ++ ) 
    {
    array [ i ] = int.Parse ( str [ i ] + " " )  ;                                  // Считываем строки по индексу ,                                                 
    }                                                                               // переводим в int.
    for ( int i = 0 ; i < str.Length ; i ++ ) 
    {
    Summma = Summma + array[ i ] ;                                                  // Считаем сумму элементов.
    }
    return Summma ;
}

void BodyPrograme ()                                                                // Решение задачи.
{                                                              
    int temp = 0 ;
    int Figure = GenerateRandomNumber ( ) ;
    Console.WriteLine ( $" Для решения этой задачи сгенерируем случайное число :  { Figure } " ) ;
    int result = ConvertNumberArray ( Figure , temp ) ;
    Console.WriteLine ( $" Сумма элементов этого числа будет равна :    { result } " ) ;
}

BodyPrograme () ;