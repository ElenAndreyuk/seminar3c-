// выводим кубы чисел 
Console.WriteLine("Введите целое число");
int n = int.Parse(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= n ; i++)
    {
        Console.Write(Math.Pow(i, 3));

        if(i < n)
        {
            Console.Write(", ");

        }
    }
}
else
{
    for (int i = -1; i >= n ; i = i -1)
    {
     Console.Write(Math.Pow(i, 3));
        if(i > n)
        {
            Console.Write(", ");
        }
    }
}