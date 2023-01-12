
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Здраствуй Машенька!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}