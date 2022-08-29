Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура! Это же МАША!");
}
else
{
    Console.Write("ааа, это опять ты, ");
    Console.WriteLine(username);
}