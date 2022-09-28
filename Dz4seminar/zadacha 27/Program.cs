// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12



  int SumOfDigits(int number)
  {
    int digitCount = (int)Math.Log10(number) + 1;
    int result = 0;
    for (int i = 0; i < digitCount; i++)
    {
      int a =  number % 10;
      result = result +  a;
      number = number / 10;
    }
   return result;
  }

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sumNumber}");