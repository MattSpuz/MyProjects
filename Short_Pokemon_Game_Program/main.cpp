#include "pokemon.h"
#include <iostream>
#include <stdlib.h>
using namespace std;

Pokemon Poke;
Pokemon Poke2;
Pokemon Poke3;
int GymBadges = 0;

/*
 * Damage check determines how much damage us delt
*/
int DamageCheck(int Attack, int Defence) {
    int dmg;
    dmg = rand() % 10 + (Attack - Defence / 2);
    if(dmg < 1) {
        dmg = 1;
    }
    return dmg;
}


/*
 * this is the code for battles in the game
*/
void BattleDawn(int NumPokemon, int who) {
    Pokemon GymLeader;
    int NumAtt = 0;
    int choice = 1;
    int MaxHP;
    int Health;
    int Attack;
    int Defence;
    int Speed;
    int E_MaxHP;
    int E_Health;
    int E_Attack;
    int E_Defence;
    int E_Speed;
    int Exp;

    if(who == 1) {               //Decides who/where you will fight
        GymLeader.BF();
        E_Health = GymLeader.getHP();
        E_Attack = GymLeader.getAttack();
        E_Defence = GymLeader.getDefence();
        E_Speed = GymLeader.getSpeed();
        Exp = rand() % 56 + 150;
    } else if(who == 2) {
        GymLeader.LC();
        E_Health = GymLeader.getHP();
        E_Attack = GymLeader.getAttack();
        E_Defence = GymLeader.getDefence();
        E_Speed = GymLeader.getSpeed();
        Exp = rand() % 56 + 1250;
    } else if(who == 3) {
        GymLeader.MtV();
        E_Health = GymLeader.getHP();
        E_Attack = GymLeader.getAttack();
        E_Defence = GymLeader.getDefence();
        E_Speed = GymLeader.getSpeed();
        Exp = rand() % 56 + 5000;
    } else if(who == 4) {
        GymLeader.EncounterDawn();
        E_Health = GymLeader.getHP();
        E_Attack = GymLeader.getAttack();
        E_Defence = GymLeader.getDefence();
        E_Speed = GymLeader.getSpeed();
        Exp = 1500;
    } else if(who == 5) {
        GymLeader.EncounterGwyn();
        E_Health = GymLeader.getHP();
        E_Attack = GymLeader.getAttack();
        E_Defence = GymLeader.getDefence();
        E_Speed = GymLeader.getSpeed();
        Exp = 5000;
    } else {
        GymLeader.EncounterGOD();
        E_Health = GymLeader.getHP();
        E_Attack = GymLeader.getAttack();
        E_Defence = GymLeader.getDefence();
        E_Speed = GymLeader.getSpeed();
        Exp = 10000;
    }
    E_MaxHP = E_Health;

    if(NumPokemon == 3) {           //Starting with 2 pokemon
        cout << "Which Pokemon would you like to use first" << endl;
        cout << "(1) " << Poke.getPokemon() << endl;
        cout << "(2) " << Poke2.getPokemon() << endl;
        cin >> choice;
        if(choice == 1) {
            Health = Poke.getHP();
            Attack = Poke.getAttack();
            Defence = Poke.getDefence();
            Speed = Poke.getSpeed();
        } else {
            Health = Poke2.getHP();
            Attack = Poke2.getAttack();
            Defence = Poke2.getDefence();
            Speed = Poke2.getSpeed();
        }
    } else if(NumPokemon > 3) {     //Starting with 3 pokemon
        cout << "Which Pokemon would you like to use first" << endl;
        cout << "(1) " << Poke.getPokemon() << endl;
        cout << "(2) " << Poke2.getPokemon() << endl;
        cout << "(3) " << Poke3.getPokemon() << endl;
        cin >> choice;
        if(choice == 1) {
            Health = Poke.getHP();
            Attack = Poke.getAttack();
            Defence = Poke.getDefence();
            Speed = Poke.getSpeed();
        } else if(choice == 2){
            Health = Poke2.getHP();
            Attack = Poke2.getAttack();
            Defence = Poke2.getDefence();
            Speed = Poke2.getSpeed();
        } else {
            Health = Poke3.getHP();
            Attack = Poke3.getAttack();
            Defence = Poke3.getDefence();
            Speed = Poke3.getSpeed();
        }
    } else {                        //Starting with 1 pokemon
        Health = Poke.getHP();
        Attack = Poke.getAttack();
        Defence = Poke.getDefence();
        Speed = Poke.getSpeed();
    }
    MaxHP = Health;

    cout << "---------------------------------------------" << endl;
    cout << "You have challenged " << GymLeader.getPokemon() << " to A Pokemon Battle!" << endl;
    cout << "---------------------------------------------" << endl;

    /*
     * This while loop is The Actual battle
    */
    while(Health > 0 && E_Health > 0) {
        if(Speed > E_Speed) {
            E_Health -= DamageCheck(Attack, E_Defence);  //you attack
            if(E_Health > 0) {
                Health -= DamageCheck(E_Attack, Defence);  //opponent attacks
            }
        } else {
            Health -= DamageCheck(E_Attack, Defence);  //opponent attacks
            if(Health > 0 ) {
                E_Health -= DamageCheck(Attack, E_Defence);  //you attack
            }
        }
        NumAtt++;
    }

    /*
     * This if Statement is to ensure that the enemies final HP is at minimum 0
    */
    if(Health < 0) {
        Health = 0;
    } else {
        E_Health = 0;
    }

    cout << "----" << endl;
    cout << NumAtt << " Turns passed" << endl;
    cout << "----" << endl;
    cout << "Your HP: " << Health << "/" << MaxHP << endl;
    cout << "Your Avarage DPS: " << DamageCheck(Attack, E_Defence) << endl;
    cout << "----" << endl;
    cout << "Opponent's HP: " << E_Health << "/" << E_MaxHP << endl;
    cout << "Opponent's Avarage DPS: " << DamageCheck(E_Attack, Defence) << endl;
    cout << "--------" << endl;

    /*
     * This is where your rewards are givin if you won
    */
    if(Health > 0 && E_Health == 0) {
        cout << "YOU WIN!!!" << endl;

        if(choice == 1) {                           //this will determine who gets the exp
            Poke.getExp(Exp);
        } else if(choice == 2) {
            Poke2.getExp(Exp);
        } else {
            Poke3.getExp(Exp);
        }

        if(who > 3) {
            cout << "You earn +1 Badge" << endl;
            GymBadges += 1;
        }
        cout << "You earn +" << Exp << "xp" << endl;
    } else {
        cout << "You lose" << endl;
        if(who > 3) {
            cout << "try again next time to earn the badge" << endl;
        }
    }
}


/*
 * this is the main menu for the game
*/
int MainMenu() {
    int NumPokemon = 1;
    int quit = 1;
    while(quit == 1) {
        int choice;

        //Selecting Your first, second and third pokemon
        if(NumPokemon == 1) {
            Poke.selectPokemon();
            NumPokemon++;
        } else if(NumPokemon == 2 && Poke.getLevel() >= 16) {
            Poke2.selectPokemon();
            NumPokemon++;
        } else if(NumPokemon == 3 && Poke.getLevel() >= 36) {
            Poke3.selectPokemon();
            NumPokemon++;
        }

        //The Main Menu Starts here
        cout << "---------------" << endl;
        cout << "What whould you like to do" << endl;
        cout << "(1) Train : Beginners Forest" << endl;
        cout << "(2) Train : Lush Caves" << endl;
        cout << "(3) Train : Mt. Valcano" << endl;
        cout << "(4) Gym Battle" << endl;
        cout << "(5) See Pokemon" << endl;
        cout << "(6) Quit Game" << endl;
        cin >> choice;
        if(choice == 1) {
            BattleDawn(NumPokemon, 1);
        } else if(choice == 2) {
            if(GymBadges < 1) {
                cout << "You Need 1 Gym badges to enter the Lush forests" << endl;
                cout << "You can see the number of Gym badges you have in the 'See Pokemon' Screen" << endl;
            } else {
                BattleDawn(NumPokemon, 2);
            }
        } else if(choice == 3) {
            if(GymBadges < 2) {
                cout << "You Need 2 Gym badges to enter Mt. Valcano" << endl;
                cout << "You can see the number of Gym badges you have in the 'See Pokemon' Screen" << endl;
            } else {
                BattleDawn(NumPokemon, 3);
            }
        } else if(choice == 4) {
            if(GymBadges == 0) {
                BattleDawn(NumPokemon, 4);
            } else if(GymBadges == 1){
                BattleDawn(NumPokemon, 5);
            } else {
                BattleDawn(NumPokemon, 6);
            }
        } else if(choice == 5) {
            cout << "-------------------------" << endl;
            cout << "POKEMON Statistics..." << endl;
            cout << "Number of badges: " << GymBadges << endl;
            Poke.Print();
            if(NumPokemon == 3) {
                Poke2.Print();
            } else if(NumPokemon == 4) {
                Poke2.Print();
                Poke3.Print();
            }
        } else {
            quit = 2;
        }
        if(GymBadges == 3) {
            return 1;
        }
    }
    return 0;
}

int main() {
    int win = 0;
    cout << "Hello and Welcome to POKEMON!" << endl;
    cout << "The goal of this game is to defeat all three Gym Leaders!" << endl;
    cout << "----------" << endl;
    cout << "Good luck!" << endl;
    cout << "----------" << endl;
    win = MainMenu();
    if(win == 1) {
        cout << "YOU BEAT THE GAME!" << endl;
    } else {
        cout << "You quit the game..." << endl;
    }
}
