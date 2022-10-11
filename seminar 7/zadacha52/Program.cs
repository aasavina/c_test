﻿/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int[,] array =
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};



    

        for (int i = 0; i < array.GetLength(1); i++)
        {
            double avg=0;
            for (int j = 0; j < array.GetLength(0); j++)
                {
                 avg= array[j,i]+avg;
                } 
            avg=avg/(array.GetLength(0));
            Console.Write(Math. Round(avg,1));
            if (i<array.GetLength(1)-1)
            {
                Console.Write("; ");
            }
    
        }


