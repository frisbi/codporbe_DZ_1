﻿Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numA > max)
{
    max = numA;
}

if (numB > max)
{
    max = numB;
}

if (numC > max)
{
    max = numC;    
}

Console.Write($"Число {max} является максимальным");