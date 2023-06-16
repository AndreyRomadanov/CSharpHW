/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"*/


BodyBild ( ) ;

void BodyBild ( )                                       // В этом методе вводим данные и решаем задачу методом рекурсии.
{
    Console.Write ( " Введите число M  : " ) ;
    int M = int.Parse ( Console.ReadLine ( ) ! ) ;
    Console.Write ( " Введите число N  : " ) ;
    int N = int.Parse ( Console.ReadLine ( ) ! ) ;
    if ( N > M ) 
      {
         EnumerationEvenNumbers ( N , M ) ;            
      } 
     else 
      {
         EnumerationEvenNumbers ( M , N ) ;
      }
}

void EnumerationEvenNumbers ( int count , int i )        // Этим методом ( рекурсия ) перебираем числа в указанном промежутке,
{                                                        // выводим на экран чётные числа.
    while ( count >= i )
    {
       if ( i % 2 == 0 )
       {
         Console.Write ( $" { i } " ) ; 
         i = i + 1 ; 
       }
         EnumerationEvenNumbers ( count , i + 1 ) ;       
    return;
    }
}