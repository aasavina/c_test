Console.WriteLine("Введите число1");
int numberA =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2");
int numberB =  Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max =numberB;
Console.WriteLine(max);