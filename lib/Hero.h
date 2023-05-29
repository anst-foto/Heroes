#ifndef HEROES_HERO_H
#define HEROES_HERO_H

#include <string>

using namespace std;

class Hero {
private:
    string _name;

protected:
    int _health;
    int _damage;

    Hero(string name) {
        _name = name;
    }

public:
    virtual void Attack(Hero* enemy) = 0;

    string GetName() {
        return _name;
    }

    int GetHealth() {
        return _health;
    }

    int GetDamage() {
        return _damage;
    }

    void SetHealth(int newHealth) {
        if (newHealth <= 0) {
            _health = 0;
        } else {
            _health = newHealth;
        }
    }
};


#endif //HEROES_HERO_H
