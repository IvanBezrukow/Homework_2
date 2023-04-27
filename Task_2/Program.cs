int ThirdNumber(int num)
{
    int result = 0;
    while (num > 1000)
    {
        num = num / 10;
    }
    result = num % 10;
    return result;
}




try
{
    Console.Write("Введите 3-х значное число = ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 < 1000)
        if (num1 < 99)
        {
            Console.WriteLine("Третье цифры нет");
        }
        else Console.WriteLine($"Третье число = {ThirdNumber(num1)}");
    else
        Console.WriteLine("Необходимо ввести 3-х значное число");
}
catch
{
    Console.WriteLine("Можно вводить только числа");
}