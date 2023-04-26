﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

SecondElemThreeDigitNumber();                                                   // Запускаем решение задачи.

void SecondElemThreeDigitNumber()                                               // Основной метод решения задачи.
{
int rand1 = new Random ().Next ( 100 , 1000 ) ;                                 // Генератор сучайного числа.
Console.WriteLine ( " Случайное трёхзначное число :  " + rand1 ) ;              // Записываем сгенерированное число.
int result1 = indexarray ( rand1 ) ;                                            // Второй элемент трёхзначного числа.
Console.WriteLine ( " Второй злемент в трёхзначном числе :  " +  result1   ) ;  // Записываем результат задачи.
}

int indexarray ( int rand )                                                     // Метод решения задачи.
{
int count = 0 ;                                                                 // Вводим переменную.
string str = rand.ToString () ;                                                 // Переводим число из int в string.
int [] array = new int [str.Length] ;                                           // Прописываем строки как массив чисел.  
while ( count < str.Length )                                                    // Пока переменная меньше конечного индекса массива. (Цикл)
{
  array [ count ] = int.Parse ( str [ count ] + " " )  ;                        // Считываем строки по индексу , переводим в int.
    count ++ ;                                                                  // Увеличиваем переменную на один.
} 
int result = array [ 1 ] ;                                                      // Присваиваем результату элемент с индксом один.
 return result ;                                                                // Возвращаем результат в основной метод.
} 
