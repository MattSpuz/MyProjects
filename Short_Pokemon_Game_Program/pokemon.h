#include "pokestats.h"
#include <string>
using namespace std;

class Pokemon : PokeStats
{
public:
    Pokemon();
    void setPokemon(string pokemon) {
        this->pokemon = pokemon;
    }
    void setSpecific(int Poke) {
        this->Poke = Poke;
    }
    void setSpecific2(int Poke) {
        this->Poke = Poke;
    }
    string getPokemon() {
        return pokemon;
    }

    int getHP() {
        return HP;
    }
    int getAttack() {
        return Attack;
    }
    int getDefence() {
        return Defence;
    }
    int getSpeed() {
        return Speed;
    }
    int getExp() {
        return Exp;
    }
    int getLevel() {
        return Level;
    }
    int getEvolution() {
        return Evolution;
    }
    int getSpecific() {
        return Poke;
    }
    int getSpecific2() {
        return Poke;
    }

    void Print() ;
    void selectPokemon();
    void getExp(int exp);
    void Evolve();
    void Evolve2();

    //these are the encounters you will face
    void EncounterDawn();
    void EncounterGwyn();
    void EncounterGOD();
    void BF();
    void LC();
    void MtV();
private:
    string pokemon;
    int Poke;
};
