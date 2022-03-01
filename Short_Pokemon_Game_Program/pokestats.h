#pragma once

class PokeStats
{
public:
    PokeStats();
    void setHpAttackDefenceSpeed(int HP, int Attack, int Defence, int Speed) {
        this->HP = HP;
        this->Attack = Attack;
        this->Defence = Defence;
        this->Speed = Speed;
    }
    void setExpMaxexpLevelEvolution(int Exp,int MaxExp, int Level, int Evolution) {
        this->Exp = Exp;
        this->MaxExp = MaxExp;
        this->Level = Level;
        this->Evolution = Evolution;
    }

protected:
    int HP;
    int Attack;
    int Defence;
    int Speed;
    int Exp;
    int MaxExp;
    int Level;
    int Evolution;
};
