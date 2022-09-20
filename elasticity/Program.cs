double Elasticity (double price1, double price2, double volume1, double volume2)
{
double result = -((volume2-volume1)/(price2-price1))*((price1+price2)/(volume1+volume2));
return result;
}
Console.WriteLine("Введите цену 1");
double price1 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите цену 2");
double price2 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите объем 1");
double volume1 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите объем 2");
double volume2 = Convert.ToDouble( Console.ReadLine());

 double E = Elasticity ( price1, price2, volume1, volume2);
Console.WriteLine($" эластичность спроса по цене {E}");