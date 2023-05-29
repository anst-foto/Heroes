#ifndef HEROES_BARBARIAN_H
#define HEROES_BARBARIAN_H

#include "Hero.h"

class Barbarian : public Hero {
private:
    int _fatigue;

public:
    Barbarian(string name) : Hero(name) {
        _health = 90;
        _damage = 110;

        _fatigue = 0;
    }

    void Attack(Hero *enemy) override {
        auto enemyHealth = enemy->GetHealth();
        auto newHealth = enemyHealth - (_damage - _fatigue);
        enemy->SetHealth(newHealth);
        _fatigue += 10;
    }
};


#endif //HEROES_BARBARIAN_H
