//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2




//Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] dorandom3digarray(int size)
{
int[]array =new int[ size];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(100,1000); 
    //Console.Write($"{array[i]}");
}
return array;
}

void showarray(int[] incomingarray)
{
     Console.Write("Создан массив  из элементов - ");
    for (int i = 0; i < incomingarray.Length; i++)
    {
        Console.Write($"{incomingarray[i]}");
        if( i<  incomingarray.Length-1)
          {
           Console.Write(",");
          }
       
    }
     Console.Write(".");  

}


int countdiv2(int[]arr)
{
   int result=0;
   
   for (int j = 0; j < arr.Length; j++)
   {
      if (arr[j]%2==0)
        {
         result =result+1;
        }
    }
 return result;
 //Console.WriteLine($"{result}");
}

int[] newarray =  dorandom3digarray(5);
showarray(newarray );
int count =countdiv2(newarray);
Console.WriteLine($" Количество четных чисел - {count}");

