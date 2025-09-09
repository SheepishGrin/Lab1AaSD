internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество игр: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Game[] game = new Game[n];
        Random random = new Random();
        string s;
        for (int i = 0; i < n; i++)
        {
            Console.Clear();
            game[i] = new Game();
            Console.WriteLine("Введите название игры");
            game[i].name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(
                "Введите жанр игры (0-9):\n" +
                "0. Cyberpunk_Horror\n" +
                "1. Space_Survival\n" +
                "2. Medieval_Strategy\n" +
                "3. Zombie_Battle_Royale\n" +
                "4. Farming_Simulator\n" +
                "5. Racing_Drift\n" +
                "6. Superhero_Open_World\n" +
                "7. Wild_West_RPG\n" +
                "8. Military_Shooter\n" +
                "9. Fantasy_Card_Game"
                );

            game[i].genre = (Genre)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите автора данной игры");
            game[i].maker = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату покупки этой игры.\nдень");
            game[i].buyday.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("месяц");
            game[i].buyday.month = Convert.ToString(Console.ReadLine());
            Console.WriteLine("год");
            game[i].buyday.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите, пройдена игра или нет (да/нет):");
            game[i].complete = Convert.ToString(Console.ReadLine()) == "да" ? true : false;
        }
        Console.Clear();
        UncompleteGames(game, n);
        return;
    }
    private static void UncompleteGames(Game[] game, int n)
    {
        Console.WriteLine("Все непройденный игры из перечня всех игр:");
        for (int i = 0; i < n; i++)
        {
            if (!game[i].complete)
            {
                Console.WriteLine("Игра " + (i + 1) + ":");
                Console.WriteLine(
                    "Название:  " +
                    game[i].name + "\nЖанр:  " +
                    game[i].genre + "\nСоздатель:  " +
                    game[i].maker + "\nДата покупки:  " +
                    game[i].buyday.day + " " +
                    game[i].buyday.month + " " +
                    game[i].buyday.year);
                Console.WriteLine("\n");
            }
        }
    }
}

struct Boughtday 
{
	public int day;
	public string month;
	public int year;
}
enum Genre
{
    Cyberpunk_Horror,
	Space_Survival,
	Medieval_Strategy,
	Zombie_Battle_Royale,
	Farming_Simulator,
	Racing_Drift,
	Superhero_Open_World,
	Wild_West_RPG,
	Military_Shooter,
	Fantasy_Card_Game
}
struct Game
{
	public string name;
	public Genre genre;
	public string maker;
	public Boughtday buyday;
	public bool complete;
}
