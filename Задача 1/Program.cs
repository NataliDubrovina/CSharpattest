﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите первое число:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от первого до второго чисел: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);