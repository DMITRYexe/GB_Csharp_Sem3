//31. Вывести на экран кубы чисел от 1 до N
Console.WriteLine("Привет! Данная программа выводит кубы чисел от 1 до N");
Console.WriteLine("Введите N, где N целое число");

int number = Convert.ToInt32(Console.ReadLine());
int i = 1, cube = 0;
Console.WriteLine("Резульат: ");
if (CheckForPositivity(number))
   {
     while (i < number)
      {
      cube = i;
      cube = (int)Math.Pow(i, 3);
      Console.WriteLine($"{cube} ");
      i++;
      }
   }
   else if (CheckForPositivity(number) == false)
   {
      while (i > number)
      {
      cube = i;
      cube = (int)Math.Pow(i, 3);
      Console.WriteLine($"{cube} ");
      i--;
      }
   }
Console.WriteLine($"{Math.Pow(number, 3)}");
Console.ReadKey();



bool CheckForPositivity (int number)
{
   if (number>0)
   {
      return true;
   }
   else
   {
      return false;
   }   

}