#include "pokestats.h"
#include "pokemon.h"
#include <stdlib.h>
#include <iostream>
using namespace std;

Pokemon::Pokemon() : pokemon("noname") {

}

//This is used to view the pokemons stats
void Pokemon::Print() {
    cout << "------------------------" << endl;
    cout << pokemon << endl;
    cout << "HP     : " << HP << endl;
    cout << "ATTACK : " << Attack << endl;
    cout << "Defence: " << Defence << endl;
    cout << "Speed  : " << Speed << endl;
    cout << "Level  : " << Level << endl;
    cout << "Cur Exp: " << Exp << "/" << MaxExp << endl;

}

//This is used to select the players first pokemon
void Pokemon::selectPokemon() {
    cout << "--------------------------------" << endl;
    cout << "You get a NEW POKEMON!" << endl;
    cout << "--------------------------------" << endl;
    cout << "Please Select your Pokemon" << endl;
    cout << "(1) Charmander" << endl;
    cout << "(2) Squirtle" << endl;
    cout << "(3) Bulbasaur" << endl;
    int i;
    int end = 1;
    cin >> i;
    while(i < 1 || i > 3) {
        cout << "ERROR Please try again" << endl;
        cin >> i;
    }
    while(end == 1) {
        if(i == 1) {
            pokemon = "Charmander";
            setHpAttackDefenceSpeed(120, 51, 39, 45); //B, A, B, A
            setExpMaxexpLevelEvolution(0, 10, 1, 1);
            end++;
        } else if(i == 2) {
            pokemon = "Squirtle";
            setHpAttackDefenceSpeed(112, 49, 51, 43); //C, B, A, C
            setExpMaxexpLevelEvolution(0, 10, 1, 1);
            end++;
        } else if(i == 3){
            pokemon = "Bulbasaur";
            setHpAttackDefenceSpeed(153, 43, 36, 45); //A, C, C, A
            setExpMaxexpLevelEvolution(0, 10, 1, 1);
            end++;
        } else {
            cout << "You already have that Pokemon" << endl;
            cin >> i;
        }
    }
}

//After your pokemon gains any type of exp it MUST run through here
void Pokemon::getExp(int exp) {
    Exp = Exp + exp;
    while(Exp >= MaxExp) {
        Exp -= MaxExp;
        if(Level > 10) {
            MaxExp += (3 * Level);
        } else if(Level > 30) {
            MaxExp += (2 * Level);
        } else if(Level > 50) {
            MaxExp += (1.2 * Level);
        } else {
            MaxExp += (5 * Level);
        }
        if(Level < 100) {
            Level += 1;
            cout << "Congrats Your " << pokemon << " is now Level " << Level << "!" << endl;
            HP += rand() % 3 + 10;
            Attack += rand() % 2 + 2;
            Defence += rand() % 2 + 2;
            Speed += rand() % 2 + 2;
        }
        if(Level >= 16 && Evolution == 1) {
            Evolve();
            cout << "WOW, Your Pokemon Evolved into A " << pokemon << "!" << endl;
            Evolution++;
        } else if(Level >= 36 && Evolution == 2){
            Evolve2();
            cout << "WOW, Your Pokemon Evolved into A " << pokemon << "!" << endl;
            Evolution++;
        }
    }
}

//Pokemons first evolution
void Pokemon::Evolve() {
    if(pokemon == "Charmander") {
    pokemon = "Charmeleon";
    HP += 59;
    Attack += 18;
    Defence += 13;
    Speed += 15;
    } else if(pokemon == "Squirtle") {
    pokemon = "Wartortle";
    HP += 51;
    Attack += 15;
    Defence += 18;
    Speed += 10;
    } else if(pokemon == "Bulbasaur") {
    pokemon = "Ivysaur";
    HP += 74;
    Attack += 13;
    Defence += 10;
    Speed += 15;
    }
}

//Pokemons second/final evolution
void Pokemon::Evolve2() {
    if(pokemon == "Charmeleon") {
    pokemon = "Charizard";
    HP += 59;
    Attack += 18;
    Defence += 13;
    Speed += 15;
    } else if(pokemon == "Wartortle") {
    pokemon = "Blastoise";
    HP += 51;
    Attack += 15;
    Defence += 18;
    Speed += 10;
    } else if(pokemon == "Ivysaur") {
    pokemon = "Venusaur";
    HP += 74;
    Attack += 13;
    Defence += 10;
    Speed += 15;
    }
}

//Encounters you will face
void Pokemon::EncounterDawn() {
    setHpAttackDefenceSpeed(450, 89, 94, 100);
    setPokemon("Dawn");
}

void Pokemon::EncounterGwyn() {
    setHpAttackDefenceSpeed(670, 164, 150, 163);
    setPokemon("Gwyn");
}

void Pokemon::EncounterGOD() {
    setHpAttackDefenceSpeed(1000, 248, 239, 220);
    setPokemon("GOD");
}

void Pokemon::BF() {
    setHpAttackDefenceSpeed(rand() % 100 + 101,rand() % 45 + 21,rand() % 50 + 13,rand() % 68 + 12);
    setPokemon("Wild Pokemon");
}

void Pokemon::LC() {
    setHpAttackDefenceSpeed(rand() % 100 + 324,rand() % 45 + 83,rand() % 50 + 79,rand() % 68 + 100);
    setPokemon("Strong wild Pokemon");
}

void Pokemon::MtV() {
    setHpAttackDefenceSpeed(rand() % 100 + 568,rand() % 45 + 132,rand() % 50 + 140,rand() % 68 + 150);
    setPokemon("Very Strong wild Pokemon");
}
