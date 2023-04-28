string Days(int num)
{
    int num0 = 0;
    int num2 = 6;
    int num3 = 5;
    int num4 = 8;
    if (num > num0 && num < num2)
    {
        return "Нет, этот день не является выходным.";
    }
    else if (num > num3 && num < num4)
    {
        return "Да, этот день является выходным.";
    }
    return "";
}




try
{
    Console.Write("Введите номер дня = ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 > 0 && num1 < 8)
        Console.WriteLine(Days(num1));
    else
        Console.WriteLine("Необходимо вводить целые числа от 1 до 7");
}
catch
{
    Console.WriteLine("Можно вводить лишь целые числа");
}