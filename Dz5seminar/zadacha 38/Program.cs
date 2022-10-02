//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
double[] dorandomdoublearraye(int size)
{
double[]array =new double[ size];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(0,100); 
    
}
return array;

}
void showarray(double[] incomingarray)
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

double DiffMaxMin(double[] incomingarray)
{
  double result =0;
  int maxnum=0;
  int minnum=0;
  for (int i = 0; i < incomingarray.Length; i++)
  {
    if (incomingarray[i]> incomingarray[maxnum])
    maxnum=i;
    if (incomingarray[i]< incomingarray[minnum])
    minnum=i;
  }
  result=incomingarray[maxnum]-incomingarray[minnum];

  return result;
}

double[] newarray =dorandomdoublearraye(6);
showarray(newarray);
double diff = DiffMaxMin (newarray);
Console.WriteLine($" Разница в значении макс и мин элемента массива = {diff}");