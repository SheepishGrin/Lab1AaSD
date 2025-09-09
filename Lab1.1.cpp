
#include <iostream>
#include <Windows.h>
#include <string>
using namespace std;
enum Genre {
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
};
struct Boughtday
{
    int day;
    string month;
    int year;
};


struct Game {
    string name;
    Genre genre;
    string maker;
    Boughtday buyday;
    bool complete;
};

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    cout << "Введите количество игр: ";
    int n; cin >> n;
    int l;
    string bol;
    Game* game = new Game[n];
    for (int i = 0; i < n; i++)
    {
        system("cls");
        game[i] = Game();
        cout << "Введите название игры: ";
        cin >> game[i].name;
        cout <<
            "Введите жанр игры (0-9):\n" <<
            "0. Cyberpunk_Horror\n" <<
            "1. Space_Survival\n" <<
            "2. Medieval_Strategy\n" <<
            "3. Zombie_Battle_Royale\n" <<
            "4. Farming_Simulator\n" <<
            "5. Racing_Drift\n" <<
            "6. Superhero_Open_World\n" <<
            "7. Wild_West_RPG\n" <<
            "8. Military_Shooter\n" <<
            "9. Fantasy_Card_Game" << endl;
        cin >> l;
        game[i].genre = (Genre)l;
        cout << "Введите автора данной игры: ";
        cin >> game[i].maker;
        cout << "Введите дату покупки этой игры.\nдень" << endl;
        cin >> game[i].buyday.day;
        cout << "месяц" << endl;
        cin >> game[i].buyday.month;
        cout << "год" << endl;
        cin >> game[i].buyday.year;
        cout << "Укажите, пройдена игра или нет (да/нет): ";
         cin >> bol;
        game[i].complete = bol == "да" ? true : false;

        system("cls");
        UncompleteGames(game, n);
        return 0;
    }
}


void UncompleteGames(Game* game, int n) {
    cout << "Все непройденный игры из перечня всех игр:";
    for (int i = 0; i < n; i++)
    {
        if (!game[i].complete)
        {
            cout << "Игра " << (i + 1) << ":";
            cout <<
                "Название:  " <<
                game[i].name << "\nЖанр:  " <<
                game[i].genre << "\nСоздатель: " <<
                game[i].maker << "\nДата покупки:  " <<
                game[i].buyday.day << " " <<
                game[i].buyday.month << " " <<
                game[i].buyday.year << endl;
        }
    }
}
