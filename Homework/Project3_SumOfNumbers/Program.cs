//35. Подсчитать сумму цифр в числе. Сделать подпрограмму.
Console.WriteLine("Привет! Данная программа считает сумму чисел через метод С#");
Start:
Console.WriteLine("Введите целое число: ");

int inputNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Sum(inputNumber)}");

int Sum (int x)
{
   int i, sum=0;
   while (x != 0)
   {
      i = x % 10;
      sum=sum + i;
      x /= 10;
   }
   sum = sum + x;
   return sum;
}

goto Start;