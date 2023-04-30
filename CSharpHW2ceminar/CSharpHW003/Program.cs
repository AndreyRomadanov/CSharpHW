// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


WrithNumberDayweek ( ) ;                                              // Выполняется метод  WrithNumberDayweek.


void WrithNumberDayweek ( )                                           //  Метод WrithNumberDayweek.
{
Console.Write ( " Введите цифру соответствующую дню недели :   " ) ;  // Просим ввести цифру, обозначающую день недели. 
int number = int.Parse ( Console.ReadLine () !) ;                     // Вводим переменную , считываем и запоминаем введённую цифру.
int daynumber = DayWeek (  number  ) ;                                // Вводим переменную , выполняется метод DayWeek.
WeekdayHoliday ( daynumber ) ;                                        // Выполняется метод WeekdayHoliday.
}


int DayWeek ( int number  )                                           // Метод DayWeek.
{ 
 int daynumber = 0 ;                                                  // Вводим переменную. 
if  ( number == 1 ) 
{
    Console.Write ( " В России первым днём недели называется понедельник " ) ;
    daynumber = 1 ;
}
else if  ( number == 2 )
{
    Console.Write ( " В России вторым днём недели называется вторник " ) ;
    daynumber = 1 ;
}
else if  ( number == 3 )
{
    Console.Write ( " В России третим днём недели называется среда " ) ;
    daynumber = 1 ;
}
else if  ( number == 4 )
{
    Console.Write ( " В России четвёртым днём недели называется четверг " ) ;
    daynumber = 1 ;
}
else if  ( number == 5 )
{
    Console.Write ( " В России пятым днём недели называется пятница " ) ;
    daynumber = 1 ;
} 
else if  ( number == 6 )
{
    Console.Write ( " В России шестым днём недели называется суббота " ) ;
    daynumber = 2 ;
}
else if  ( number == 7 )
{
    Console.Write ( " В России седьмым днём недели называется воскресенье " ) ;
    daynumber = 2 ;
}
else
{
    Console.Write ( " Такого дня недели в России - нет. " ) ; 
     daynumber = 0 ;
}
    return daynumber ;
} 
 

void WeekdayHoliday ( int daynumber )                                 // Метод WeekdayHoliday.
{
if ( daynumber == 2  ) 
{
    Console.Write ( " - выходной день. " ) ;
}
else if ( daynumber == 1 )
{
     Console.Write ( " - рабочий день. " ) ;
}
else
{
    Console.Write ( "  " ) ;
}
}
