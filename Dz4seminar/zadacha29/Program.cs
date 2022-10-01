//Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .

//5 -> [1, 2, 5, 7, 19]

//3 -> [6, 1, 33] 




Console.WriteLine("Введите длинну массива");
int lenght =Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];

for (int i=0;i<lenght; i++)
   {
    array[i]= new Random().Next(1,100); 
    
   }

void PrintArray(int[] arr)
{
 Console.Write("[");
 for (int i=0;i<lenght; i++)
    {
     Console.Write(array[i]); 
      if (i<lenght-1)
      {
         Console.Write(",");
      }
    }

 Console.Write("]");
}

PrintArray(array);

