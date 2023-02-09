// Алгоритм Евклида. (Нахождение НОД).
void NOD(int a=11, int b=121)
{
   int a1 =a; int b1 = b;
   while (a != b)
      if (a > b)
         a -= b; // сокр. запись a=a-b
      else
         b -= a;
   System.Console.WriteLine(a); // (НОД)
   System.Console.WriteLine(a1*b1/a); // Наименьшее общ. кратное (НОК)
}
NOD();
