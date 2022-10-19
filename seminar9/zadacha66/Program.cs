/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


    

Console.WriteLine("Введите число m");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n =Convert.ToInt32(Console.ReadLine());

int SummOfdigitsInterval(int m, int n, int summ = 0)
{
    if( m<= n)
    {
        return SummOfdigitsInterval(m+1,n,summ+m);
    }
    return summ;
}

int summ = SummOfdigitsInterval(m, n);
Console.WriteLine($"Сумма  чисел  между {m} и {n} равна {summ}");