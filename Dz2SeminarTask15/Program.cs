void holiday (int weekday) 
{
  if (weekday == 6 || weekday == 7) 
  {
  Console.WriteLine("да");
  }
  else if (weekday < 1 || weekday > 7) 
  {
    Console.WriteLine("Вы ввели некорректное число");
  }
  else Console.WriteLine("нет");
}

Console.WriteLine("Введите номер дня недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());
holiday(weekday);
