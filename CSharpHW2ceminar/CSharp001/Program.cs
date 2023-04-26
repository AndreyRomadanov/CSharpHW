// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

SecondElemThreeDigitNumber();

void SecondElemThreeDigitNumber()
{
int rand1 = new Random ().Next ( 100 , 1000 ) ;
Console.WriteLine ( " Случайное трёхзначное число :  " + rand1 ) ;
int result1 = indexarray ( rand1 ) ;
Console.WriteLine ( " Второй злемент в трёхзначном числе :  " +  result1   ) ; 
}
int indexarray ( int rand ) 
{
int count = 0 ;
string str = rand.ToString () ; 
int [] array = new int [str.Length] ;
while ( count < str.Length )
{
  array [ count ] = int.Parse ( str [ count ] + " " )  ;
    count ++ ;
} 
int result = array [ 1 ] ;
 return result ;
} 
