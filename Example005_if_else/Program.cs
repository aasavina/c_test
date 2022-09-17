Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
Console.WriteLine( "Ура этоже маша");
}
else
{
Console.Write("Привет незнакомец ");
Console.WriteLine(username);
}