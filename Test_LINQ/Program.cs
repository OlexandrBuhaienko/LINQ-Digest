// See https://aka.ms/new-console-template for more information
using Test_LINQ;
using System.Linq;
List<Player> players = new List<Player>
{
    new Player("John", 100),
    new Player("Bill", 220),
    new Player("Derek", 260),
    new Player("Clark", 241)
};
List<Player> players2 = new List<Player>
{
    new Player("Mike", 300), 
    new Player("Jordan", 120)
};

//List<Player> filteredPlayers = new List<Player>();
//Вибірка за допомогою ключових слів LINQ
var filteredPlayers = from Player player
                      in players
                      where player.Level > 200
                      select player;
//Вибірка за допомогою методів розширення LINQ
var filteredPlayers2 = players.Where(player => player.Level> 200).Select(player => player);
//Вибірка за допомогою методів розширення, + додаткові умови для вибірки
var filteredPlayers3 = players.Where(player => player.Name.ToUpper().StartsWith('C')).Select(player => player);
//Сортуваня та вибірка методами розширення LINQ
var orderedPlayersByLevel = players.Where(player => player.Level > 100).OrderBy(player => player.Level).Select(player => player);
//Створення анонімних типів методом промпта і функцій розширення LINQ
var newPlayers = from Player player in players select new { Name = player.Name, DateOfBirth = DateTime.Now };
var newPlayers2 = players.Select(player => new { Name = player.Name, DateOfBirth = DateTime.Now });
//foreach ( var player in newPlayers2)
//{
//    Console.WriteLine($"{player.Name} - {player.DateOfBirth}");
//}


//Об'єднуємо колекції за допомогою методу розширення LINQ - "Union"
var unitedTeam = players.Union(players2);
//foreach (var player in unitedTeam)
//{
//    Console.WriteLine($"{player.Name} - {player.Level} level!");
//}

//.Take(1) - залишити в колекції лише один перший елемент
// Відповідно Take(2) - залишить 2 перші елементи
// Skip(1) - Пропустить в колекції лише один перший елемент
// Skip(2) - Відповідно

//TakeWhile(умова) - залишає лише ті елементи, що відповідають умові, до першої невідповідності умові.
//SkipWhile(умова) - те саме, тільки воно пропускає елементи, а не залишає.
//Взяти того, в кого ім'я починається на букву "B"
// Відсортовані колекції з якими ми проводили маніпуляції за допомогою LINQ, зберігаються в типі IEnumerable
// Щоб зберігати їх в типі колекції, наприклад List. Просто в кінці ставимо .ToList();
var skippedPlayer = players.TakeWhile(player => player.Name.ToUpper().StartsWith("B"));
foreach ( var player in skippedPlayer)
{
    Console.WriteLine($"{player.Name} - {player.Level} level!");
}