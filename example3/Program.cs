﻿// Задача №3. Напишите программу, которая будет выдавать название дня недели 
// по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница


Console.Write("Введите число от 0 до 7: ");
int number1 = int.Parse(Console.ReadLine());
if (number1 == 1)
{
  Console.Write("Сегодня понедельник");
}