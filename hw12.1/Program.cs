//определить список пользователей
using hw12._1.Model;

List<User> users = new List<User>(4) { 
    new User() { Name = "Иванов В.А.", Login ="user", IsPremium = true },
    new User() { Name = "Петров С.У.", Login ="user1", IsPremium = false },
    new User() { Name = "Сидоров Д.В", Login ="user2", IsPremium = true },
    new User() { Name = "Камышов И.Ю", Login ="user3", IsPremium = false }};

try
{
    
    users.ForEach(user =>
    {
        if (user.IsPremium)
            Console.WriteLine($"Привет {user.Name}! Ваш статус премиум!");
        else
        {
            Console.WriteLine($"Привет {user.Name}!");
            ShowAds();
        }
        Console.WriteLine("");

    });

    Console.ReadKey();
}
//Console.WriteLine
catch (IOException ex) { Console.WriteLine(ex); }
//ReadKey
catch (InvalidOperationException ex) { Console.WriteLine(ex); }

    
static void ShowAds()
{
    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}