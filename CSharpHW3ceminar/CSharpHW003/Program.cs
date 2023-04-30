//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


calvalarray ( ) ;                                    //Применяем метод.Решаем задачу.

void calvalarray ( )                                 // Метод. Ввод данных , решение задачи.
{
int N = promt ( " Введите число :  " ) ;
int modul =  N  ;
int variable = 1 ;
Calculatingvalues ( modul , variable ) ;
}

int promt ( string message )                          // Метод. Ввод данных.
{ 
Console.Write ( message) ;
int number = int.Parse ( Console.ReadLine () ! ) ;
return number ;
} 

void Calculatingvalues ( int n , int var )            // Метод. Решение.
{
if ( n > 1 || n == 1)                                 // Решение , если введённое число больше или соответствует единице.
{
while ( var < n || var == n ) 
{
double meaning = var ;
meaning = Math.Pow ( meaning , 3 )  ;
Console.Write ( "  " + meaning   ) ;
var ++ ;
}
}                                             
else                                                  // Решение , если введённое число меньше единицы.
{
while ( var > n || var == n )       
{
double meaning = var ;
meaning = Math.Pow ( meaning , 3 )  ;
Console.Write ( "  " + meaning   ) ;
var -- ;
}
}      
}