//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


definepolyndrome ( ) ;                                          // Запускаем метод.

void definepolyndrome ( )                                       // Метод , ищем палиндром.
{
int originalnumber = fivedigitnumber ( " Введите пятизначное число  :  " ) ;
ConvertNumberArrayCompareIndexes ( originalnumber ) ;
}


int fivedigitnumber ( string message )                          // Метод , вводим пятизначное число.
{
Console.Write ( message ) ;
int number = Math.Abs ( int.Parse ( Console.ReadLine ( ) ! ) ) ;
return number ;   
}   

void ConvertNumberArrayCompareIndexes ( int number )            // Метод , конвертируем число в массив , сравниваем индексы. 
{
int count = 0 ;                                                 // Вводим переменную.
string str = number.ToString () ;                               // Переводим число из int в string.
int [] array = new int [ str.Length ] ;                         // Прописываем строки как массив чисел.  
if ( str.Length == 5 )
{
while ( count < str.Length )                                    // Пока переменная меньше конечного индекса массива. (Цикл)
{
  array [ count ] = int.Parse ( str [ count ] + " " )  ;        // Считываем строки по индексу , переводим в int.
    count ++ ;                                                  // Увеличиваем переменную на один.
}
if ( array [ 0 ] == array [ 4 ] && array [ 1 ] == array [ 3 ] ) // Проверяем является ли число палиндромом.
{
writer (  " Данное число является палиндромом. " ) ;            // Применяем метод. Вывод , решение задачи.
} 
else
{
writer (  " Данное число не является палиндромом. " ) ;         // Применяем метод. Вывод , решение задачи.
}                                                         
}
else 
{
writer ( " Данное число не является пятизначным. " ) ;          // Применяем метод. Вывод , решение задачи.
}
}

void writer ( string message )                                  // Метод , вводим текстовое сообщение.
{                                                                
Console.WriteLine  ( message )  ;  
}  