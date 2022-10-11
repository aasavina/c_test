/*Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4*/
int[,]array =
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

void showarray(int[,] incomingarray)
{
 Console.WriteLine("Введите позицию в строке");
 int i=Convert.ToInt32(Console.ReadLine());  
 Console.WriteLine("Введите позицию в столбце");
 int j=Convert.ToInt32(Console.ReadLine()); 
 if (i<incomingarray.GetLength(0) && j<incomingarray.GetLength(1))
    {
        Console.Write("значение выбранного элемента\t"+ array[i,j]);
    }
 else
    {
         Console.Write("выбранного элемента НЕТ");
    }     
 
    
}
showarray(array);