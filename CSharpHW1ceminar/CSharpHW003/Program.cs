﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Write ( " Введите  число : " ) ;                                              //  Предлагаем ввести первое число.
int nomber = int.Parse ( Console.ReadLine ( ) !) ;                                    //  Считывает первое число.
if ( nomber % 2 == 0) { Console.WriteLine ( " Число " + nomber + " - чётное. " ) ; }  //  Вычисляет остаток , пишем резульат.
else  { Console.WriteLine ( " Число " + nomber + " - не чётное. " ) ; }               //  Пишем результат.
