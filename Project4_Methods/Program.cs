// Подпрограмма для нахождения рассстояния между двумя точками
// Такого типа задачи решаются через теор. Пифагора.
Console.WriteLine("Привет! Дананя программа ищет расстояние между 2мя точками");

// Синтаксис метода==подпрограммы:
// тип исп. данных (<double/int и т.д.>) Название (аргументы)
double Distance(double x1, double y1, double x2, double y2)
{
   return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

}
double distance=Distance(0,1,0,1); // передаем значения подпрограмме
Console.WriteLine(distance);
Console.ReadKey();
