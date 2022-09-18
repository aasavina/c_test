Console.WriteLine("Введите целое число");
double number = Convert.ToDouble(Console.ReadLine());
double count = 1;
while (count <= number)
{
 if (count % 2 ==0)
 {
    Console.Write($"{count},");
 }
count ++;
}