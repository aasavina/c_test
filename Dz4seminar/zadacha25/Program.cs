// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

double pow(int digitA, int digitB)
{
    double result=Math.Pow(digitA,digitB);
    return result;  
}
Console.Write("Введите число");
int digitA =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень");
int digitB=Convert.ToInt32(Console.ReadLine());
double digitApowDigitB = pow( digitA,  digitB);
Console.WriteLine($"число {digitA} в степени  {digitB} равно {digitApowDigitB}");