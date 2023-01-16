// Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Вводи первое число из трех");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Вводи второе число из трех");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Вводи третье число из трех");
int number3 = int.Parse(Console.ReadLine());

int number_max = number1;

if (number2 >= number_max)
{
  number_max = number2;
}
if (number3 >= number_max)
{
  number_max = number3;
}
Console.WriteLine(" Число " + number_max + " наибольшее из трех введеных тобой чисел");

