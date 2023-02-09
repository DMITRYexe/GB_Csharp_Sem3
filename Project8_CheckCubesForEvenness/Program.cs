// Проверка кубов чисел на четность. Использовать подпрограммы

bool Test (int n)
{
   if (n % 2 == 0) 
   {
      return true;
   }
   else 
   {
      return false;
   }
}

Random random=new Random();
for(int i = 0; i<10; i++)
{
   int a=random.Next(1,100);
   int b = (int)Math.Pow(a, 3);
   if (Test(b))
   {
      Console.WriteLine(b);
   }
}