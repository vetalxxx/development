int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}

int a1 = 22;
int b1 = 24;
int c1 = 5;

int a2 = 22;
int b2 = 567;
int c2 = 5;

int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max = Max(max1,max2,0); // можно и так записать int max = Max(Max(a1,b1,c1),Max(a2,b2,c2));

Console.WriteLine(max);