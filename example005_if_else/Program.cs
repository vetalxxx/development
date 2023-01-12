Console.WriteLine("Введите имя ");
string name = Console.ReadLine();

if (name.ToLower() == "маша")  // регистр букв убираем 
{
  Console.WriteLine("Ура, ты Маша");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(name);
}