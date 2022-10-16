/*Задача 56: Задайте прямоугольный двумерный массив. arrayfromuser

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,]Createarray(int rows,int columns)
{
    int[,]newarray= new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
        newarray[i,j]=Convert.ToInt32(new Random().Next(1,10));
        
       } 
    }
    return newarray;

}

void Showarray(int[,]incomingarray)
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

void Findmaxrow(int[,]arrayfromuser)
{
    int minrowsumm = 1000;
    int Rownumber = 0;
            
            for (int i = 0; i < arrayfromuser.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arrayfromuser.GetLength(1); j++)
                {
                   sum = sum + arrayfromuser[i, j];
                }
                Console.WriteLine($"Сумма {sum} для ряда {i+1}");
                if (sum < minrowsumm)
                {
                    minrowsumm = sum;
                    Rownumber =i+1;
                }
            }
            Console.WriteLine();
    Console.WriteLine( $"Строка с минимальной суммой {Rownumber}, а сумма равна {minrowsumm}");
}

int[,]newarray= Createarray(4,4);
Showarray(newarray);
Console.WriteLine();
Findmaxrow(newarray);

