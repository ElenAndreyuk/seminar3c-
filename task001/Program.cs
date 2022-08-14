// является ли пятизначное число палиндромом
Console.WriteLine("Введите пятизначное число");
try
{
    int a = int.Parse(Console.ReadLine());

    if ((a < 100000) & (a > 9999))
    {
        if((a / 10000) == (a % 10) && ((a / 1000) % 10) == ((a / 10) % 10))
        {
             System.Console.WriteLine("палиндром");   
        }
    
    else
    {
        System.Console.WriteLine("не палиндром");
    }    
    }
    if ((a > 99999) ^ (a < 1000))
    {
        System.Console.WriteLine("Это не пятизначное число");
    }
}
catch
{
    System.Console.WriteLine("Это не число");
}

    