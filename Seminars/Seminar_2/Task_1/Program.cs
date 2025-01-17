﻿// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

System.Console.WriteLine("Введите число: ");                    // Вводим условие задачи                 
int number = Convert.ToInt32(Console.ReadLine());               // Вводим переменную "number" и присваеваем ей вводимое число
if (number > 99 & number < 1000)                                // Вводим условие (в данной задаче промежуток нужных чисел)
{
    int result = number % 10;                                   // Остаток от деления на 10 (в данной задаче в трехзначном числе запятая на 1 знак уходит влево и то, что после запятой выводится на экран)
    System.Console.WriteLine(result);                           // Вывод результата предыдущего действия
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");  // Если ввели число противоречащее 8 строчке - выйдет данное сообщение
}
