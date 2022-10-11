/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/


double[,]createarray(int m,int n)
{
    double[,]array =new double[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           // array[i,j]= new Random().NextDouble ()*10;
           array[i,j] = (Convert.ToDouble(new Random().Next(-100,101)))/10;
            
        }
    }
    return array;
}


void showarray(double[,] incomingarray)
{
    
    for (int i = 0; i < incomingarray.GetLength(0); i++)
    {
       for (int j = 0; j < incomingarray.GetLength(1); j++)
       {
         Console.Write(incomingarray[i,j]+"\t");
        
       }
        Console.WriteLine();
       
    }
}

Console.Write("Введите измерение 2мерного массива M ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите измерение 2мерного массива N ");
int n=Convert.ToInt32(Console.ReadLine());

double[,]userarray=createarray(m, n);
showarray(userarray);