Console.WriteLine("Введите 3-х значное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    if (num < 1000)
    {
        int number2left = 0;
        while (num > 100)
        {
            num = num / 10;
        }
        number2left = num % 10;
        Console.WriteLine(number2left);
    }
    else
        Console.WriteLine("Введите 3-х значное число");
}
else
    Console.WriteLine("Введите 3-х значное число");