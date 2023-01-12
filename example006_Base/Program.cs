
int a = new Random().Next(1,9);
int b = new Random().Next(1,9);
int c = new Random().Next(1,9);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Наш max = ");
Console.WriteLine(max);