int SecondNumber(int num)
{
    int result = 0;
    while (num > 100)
    {
        num = num / 10;
    }
    result = num % 10;
    return result;
}




try
{
    Console.WriteLine("Введите 3-x значное число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 > 99 && num1 < 1000)
        Console.WriteLine($"Вторая цифра = {SecondNumber(num1)}");
    else
        Console.WriteLine("Число должно быть трехзначным");
}
catch
{
    Console.WriteLine("Необходимо ввести целое число");
}