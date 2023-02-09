// 36. Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Привет! Данная программа вычисляет произведение чисел от 1 до N.");
Console.WriteLine("Шаг: единица. Если число дробное, то в конце результат целых чисел домножается на это дробное число."); // по условию не сказано, что исп. только целые числа. + не указан шаг увеличения чисел.
Start:
Console.WriteLine("Введите N: ");
double N = Convert.ToDouble(Console.ReadLine());

if (CheckForPositivity(N))
{
   Console.WriteLine($"Результат: {ProductFrom1ToN(N)}");
}
else Console.WriteLine($"Результат: {ProductFrom1ToMinusN(N)}");

double ProductFrom1ToN (double multiplication)
{
   double i = 1;
   double result = 1;
   while (i<multiplication)
   {
      result = result * i;
      i++;
   }
   result = result * multiplication;
   return result;
}

double ProductFrom1ToMinusN(double multiplication) // по сути этот метод нужен лишь для чисел в диапазоне (0,1], т.к. при числе меньше 0, ответ всегда будет 0 (т.к. умножение на 0).
{
   double i = 1;
   double result = 1;
   while (i > multiplication)
   {
      result = result * i;
      i--;
   }
   result = result * multiplication;
   return result;
}

bool CheckForPositivity(double number)
{
   if (number > 1)
   {
      return true;
   }
   else
   {
      return false;
   }

}

goto Start;