#include <QCoreApplication>
#include <iostream>
#include <array>
#include <random>
#include <cstdlib>
using namespace std;

int ThrowBall() {                                      //returns random score between 1 and 10
    int score = rand() % 10;
    return score;
}

int ThrowBall(int first_throw) {                       //returns random score between 1 and 10 depending on the first throw
    int score = rand() % 10;
    while (score + first_throw >= 11) {
        score = rand() % 10;
    }
    return score;
}


void StartGame() {                                               //plays the game
    const int MAX_ROUNDS = 12;    //maximum possible rounds
    int total_Rounds = 10;//maximum rounds currently set
    int num_Of_Players;
    int throw_One;
    int throw_Two;
    string player_input;

    cout << "How many players will participate(1-4)" << endl;
    cin >> num_Of_Players;
    cout << "Ready\nSet\nBegin!" << endl;

    int score_Tally[num_Of_Players][MAX_ROUNDS];
    int total_Score[num_Of_Players];
    char special[num_Of_Players][MAX_ROUNDS];   //corresponds with score_tally so we can differentiate between strikes and spares

    cout << "-----------------------\n(press S to skip all rounds)" << endl;

    for(int i = 0; i < total_Rounds; i++) {                                   //loops through each of the ten rounds
        cout << "---------Round " << i + 1 << "!---------" << endl;
        for(int j = 0; j < num_Of_Players; j++) {                           //loops through each players turn
            cout << "Player " << j + 1 << ", enter any button to throw the ball." << endl;

            if(player_input != "S" && player_input != "s")
                cin >> player_input;    //This line has no other purpose than to make the user interact with the program

            throw_One = ThrowBall();
            throw_Two = ThrowBall(throw_One);
            score_Tally [j][i] = throw_One + throw_Two;

            //print out scores
            if(throw_One == 10) {
                cout << "Strike!!!!" << endl;
                special [j][i] = 'S';

                //if you get a strike on round 9 or 10(or spare on round 10) bonus rounds will be avaliable adding rounds to max_rounds.
                if(i == 8)
                    total_Rounds = 11;
                else if(i == 9)
                    total_Rounds = 12;
            }
            else if((throw_One + throw_Two) == 10){
                cout << "Spare!" << endl;
                special [j][i] = 'P';
                if(i == 9 && total_Rounds >= 9)
                    total_Rounds = 11;
            }
            else {
                cout << "First throw scored " << throw_One << endl;
                cout << "Second throw scored " << throw_Two << endl;
            }

            //Adds scores to previus strikes/spares if applicable
            if(i > 0) {
                if(special[j][i-1] == 'P')
                    score_Tally[j][i-1] += score_Tally[j][i];
            }
            else if(i > 1) {
                if(special[j][i-1] == 'S')
                    score_Tally[j][i-1] += score_Tally[j][i];
                if(special[j][i-2] == 'S')
                    score_Tally[j][i-2] += score_Tally[j][i];
            }
        }
    }
    for(int i = 0; i < num_Of_Players; i++) {                                   //loops through each of the ten rounds
        total_Score[i] = 0;
        for(int j = 0; j < total_Rounds; j++) {
            total_Score[i] += score_Tally[i][j];
        }
        cout << "Player " << i + 1 << ": " << total_Score[i] << endl;
    }

    cout << "end" << endl;
    //calculate t total scores
}

int main()
{
    srand(time(0));
    int play_game = 1;
    cout << "Welcome to bowling simulator!" << endl;
    while (play_game == 1) {
        cout << "(1) Start Game\n(2) Exit Program" << endl;
        cin >> play_game;
        if( play_game == 1) {
            StartGame();
        }
    }
    cout << "Have a good day!" << endl;
}
