int[] array = { 1, 2, 8, 4, 5, 6, 7, 8, 9 };

int n = array.Length;

int find = 8;

int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  } //завершит работу как только найдет число и не будет смотреть если там еще такие числа
  index++;
}