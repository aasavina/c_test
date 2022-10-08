//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//-1, -7, 567, 89, 223-> 3

int[]createarray(int m)
 {
   
    int[] array= new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число {i+1}");
        array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
 }
int numberfromuserabovezero(int[] arrayfromuser)
 {
    int count =0;
    for (int i = 0; i < arrayfromuser.Length; i++)
    {
        if (arrayfromuser[i]>0)
        {
            count=count+1;
        }
    }
    return count;
 }


Console.WriteLine("Сколько чисел вы хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int[] userarray = createarray(m);


int numberamontabovezero =numberfromuserabovezero(userarray);
Console.WriteLine($"Вы ввели {numberamontabovezero} чисел больше 0");
