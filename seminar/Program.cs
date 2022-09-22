/*

Задача 21: Напишите программу, 
которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве. 
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21


*/

double formula_dlina()

{
    Console.WriteLine("Точка 1 координаты Х");
    int tochka_1_X= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координаты У");
    int tochka_1_Y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Точка 2 координаты Х");
    int tochka_2_X= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координаты У");
    int tochka_2_Y = Convert.ToInt32(Console.ReadLine());

    
        double result = Math.Sqrt(Math.Pow(tochka_1_X - tochka_2_X, 2) + Math.Pow(tochka_1_Y - tochka_2_Y, 2));
        // double нецелый тип данных
        return result;
        // Math.Pow - вовзведение в степень (что вовзводим, в какую степень)
        // Math.Sqrt - квадртаный корень
    
}

double result = formula_dlina();
Console.WriteLine(result);