//34. Определить количество цифр в числе. Сделать подпрограмму.
using System.Diagnostics.Metrics;

int DigitsCounter (int n)
{
   int counter = 0;
   if (n!=0)
   {
      while (n!=0) 
      { counter++; n/=10; }
      return counter;
   }
   else
   {
      return 1;
   }
}

Console.WriteLine (DigitsCounter(59));
