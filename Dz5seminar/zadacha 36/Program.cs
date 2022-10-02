//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] dorandomarray(int size)
{
int[]array =new int[ size];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-99,100); 
   
}
return array;
}

void showarray(int[] incomingarray)
{
     Console.Write("Создан массив  из элементов: ");
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

int sumofpositivelements(int[] anyarray)
{
    int result=0;

    for (int i = 0; i < anyarray.Length; i++)
    {
       if(i%2 ==1)
       {
         result +=anyarray[i];
       } 

    }


    return result;
}

int[] newarray =dorandomarray(5);
showarray(newarray);
int summ =sumofpositivelements(newarray);
Console.Write($"сумму элементов, стоящих на нечётных позициях  : {summ}");