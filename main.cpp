#include <iostream>

#include "./lib/Mage.h"
#include "./lib/Barbarian.h"

using namespace std;

void PrintHeroInfo(Hero* hero) {
    cout << "=-= HERO INFO =-=" << endl;
    cout << "=- Name : " << hero->GetName() << " -=" << endl;
    cout << "=- Health : " << hero->GetHealth() << " -=" << endl;
    cout << "=-= =+= =-=" << endl;
}

int main() {
    bool exit = true;

    Hero* hero;
    Hero* enemy;

    do {
        cout << "*** HEROES ***" << endl;
        cout << "** 1. Mage **" << endl;
        cout << "** 2. Barbarian **" << endl;
        cout << "*** *** ***" << endl;

        char input;
        cin >> input;

        string name;
        cout << "Enter name : ";
        cin  >> name;

        switch (input) {
            case '1':
                hero = new Mage(name);
                enemy = new Barbarian("Enemy");

                exit = true;
                break;
            case '2':
                hero = new Barbarian(name);
                enemy = new Mage("Enemy");

                exit = true;
                break;
            default:
                exit = false;
                break;
        }
    } while (!exit);

    PrintHeroInfo(hero);
    PrintHeroInfo(enemy);

    while (true) {
        if (hero->GetHealth() == 0 || enemy->GetHealth() == 0) {
            break;
        }

        hero->Attack(enemy);
        enemy->Attack(hero);

        PrintHeroInfo(hero);
        PrintHeroInfo(enemy);
    }

    if (hero->GetHealth() == 0) {
        cout << "!!! " << enemy->GetName() << " is WINNER !!!" << endl;
    } else {
        cout << "!!! " << hero->GetName() << " is WINNER !!!" << endl;
    }

    return 0;
}
