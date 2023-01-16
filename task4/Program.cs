// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введи число > 3");
int number1 = int.Parse(Console.ReadLine());
int number2 = 0;

while (number1 > number2 + 1)
{
  number2 = number2 + 2;
  Console.Write(number2 + " ");
}
