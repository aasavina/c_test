int seconddigit(int num)
{
 int result =(num /10) %10 ;
 return result;
}

Console.WriteLine("Введите цифру XXX");
int num = Convert.ToInt32(Console.ReadLine());
int x =seconddigit(num);
Console.WriteLine($"Вторая цифра из числа {num}  это {x}");