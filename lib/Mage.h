#ifndef HEROES_MAGE_H
#define HEROES_MAGE_H

#include "Hero.h"

class Mage : public Hero {
private:
    int _mana;
public:
    Mage(string name) : Hero(name) {
        _health = 100;
        _damage = 50;

        _mana = 0;
    }

    void Attack(Hero *enemy) override {
        auto enemyHealth = enemy->GetHealth();
        auto newHealth = enemyHealth - (_damage + _mana);
        enemy->SetHealth(newHealth);
        _mana += 10;
    }
};


#endif //HEROES_MAGE_H
