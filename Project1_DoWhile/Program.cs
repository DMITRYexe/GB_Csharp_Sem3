// Ввести n от 0 до 10 с проверкой ввода
{
    int n;
    // "До тех пор пока"
    do
    {

        n = Convert.ToInt32(Console.ReadLine());

    }
    while (n < 0 || n > 10);
}