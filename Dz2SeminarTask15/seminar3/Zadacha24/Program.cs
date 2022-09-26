//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10


int getsumofrange(int startpoint, int endpoint)
{
   int result =0;
   for (int i = startpoint; i <= endpoint; i++)
  {
    result += i;
  }
   return result;
}
Console.WriteLine("введите верхнюю границу дл суммы ряда");
int userNumber= Convert.ToInt32(Console.ReadLine());
int sumofrange =getsumofrange(1,userNumber);
Console.WriteLine($"Сумма чисел от 1 до {userNumber} это {sumofrange}");