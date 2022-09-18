Console.WriteLine("Введите целое положительное или отрицательное число");
double Number = Convert.ToDouble(Console.ReadLine());
if (Number%2 ==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}