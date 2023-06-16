/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

BodyBild ( ) ;

void BodyBild ( )                                                 // В этом методе вводим данные и решаем задачу методом рекурсии.
{
    Console.Write ( " Введите число M  : " ) ;
    int M = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите число N  : " ) ;
    int N = int.Parse ( Console.ReadLine ( ) ! ) ;
    int summa = 0 ;
     if ( N > M ) 
      {
         EnumerationEvenNumbers ( N , M , summa ) ;            
      } 
     else 
      {
         EnumerationEvenNumbers ( M , N , summa ) ;
      }
}

void EnumerationEvenNumbers ( int count , int i , int sum)        // Этим методом ( рекурсия ) перебираем числа в указанном промежутке,
{                                                                 // находим сумму этих чисел.
    while ( count >= i )
    {  
        sum =sum + i ;   
        EnumerationEvenNumbers ( count , i + 1  , sum ) ;       
     return;
    }
    Console.Write ( $" Сумма всех натуральных чисел между значениями  M и N = { sum }. " ) ; 
}
