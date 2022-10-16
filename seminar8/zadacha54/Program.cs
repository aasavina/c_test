/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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



int[,]Sortarray(int[,]notsortedarray)
{
 for (int i = 0; i < notsortedarray.GetLength(0); i++)
 {
    for (int j = 0; j < notsortedarray.GetLength(1)-1; j++)
    {
       
       for (int x = 0; x < notsortedarray.GetLength(1)-1; x++)
       {
        int tempmin=0;
        if (notsortedarray[i,x]<notsortedarray[i,x+1]) 
        {
        tempmin = notsortedarray[i,x];
        notsortedarray[i,x]=notsortedarray[i,x+1];
        notsortedarray[i,x+1] = tempmin;
        }
       }

    }
 }
 return notsortedarray;
}
int[,]array2d=Createarray(3,4);
Showarray(array2d);
Sortarray(array2d);
Console.WriteLine();
Showarray(array2d);