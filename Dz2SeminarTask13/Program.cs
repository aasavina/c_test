Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 > 0)
{
    while (number>1000)
    {
        number=number/10;
    }
int third =number %10;
Console.WriteLine($"{third}");
}
else
{
    Console.WriteLine(" нет третьего числа");
}