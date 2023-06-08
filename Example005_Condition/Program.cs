Console.WriteLine("Введите имя пользователя: ");
string Username = Console.ReadLine();

if(Username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША !");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(Username);  
}