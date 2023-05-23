// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int GenerateRandomNumber (  )                                                        // Генератор сучайного числа .
{
int rand = new Random ().Next ( 0 , 10 ) ;                               
return rand ;
}

void SolvingProblem ( )                                                              // Решение задачи .
{
int A = GenerateRandomNumber (  ) ;
int B = GenerateRandomNumber (  ) ;
 Console.WriteLine ( $" Пусть первое число A = { A } " ) ;
 Console.WriteLine ( $" Пусть второе число B = { B } " ) ;
 Console.WriteLine ( $" Тогда { A } в степени { B } будет равно { Exponentiation ( A , B ) } " ) ;
}

int Exponentiation ( int Summa1 , int Summa2 )                                       // Возведение в степень .
{
 int Summa = 1 ;
   for ( int i = 0 ; i < Summa2 ; i ++ )
   {
   Summa = Summa * Summa1 ;
   }
   return Summa ;
}

SolvingProblem ( ) ;