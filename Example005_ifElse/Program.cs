Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура Маша! С возвращением, рады тебя видеть! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}