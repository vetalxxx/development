﻿//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//  456 -> 6
//  782 -> 2
//  918 -> 8
Console.Write("Введите число номер 1: ");
int number1 = int.Parse(Console.ReadLine()); //запрашиваем у пользователя 1 число
int number2 = number1%10;

Console.Write(number2);
