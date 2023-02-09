// Алгоритм Евклида. (Нахождение НОД).
void NOD(int a=11, int b=121)
{
   while (a != b)
      if (a > b)
         a -= b; // сокр. запись a=a-b
      else
         b -= a;
   System.Console.WriteLine(a);
}
NOD();
