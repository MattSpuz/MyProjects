
class Encounter
{
public:
    Encounter();
    void setHpAttackDefenceSpeed(int E_HP, int E_Attack, int E_Defence, int E_Speed, int E_RewardExp) {
        this->E_HP = E_HP;
        this->E_Attack = E_Attack;
        this->E_Defence = E_Defence;
        this->E_Speed = E_Speed;
        this->E_RewardExp = E_RewardExp;
    }

    int getE_HP() {
        return E_HP;
    }
    int getE_Attack() {
        return E_Attack;
    }
    int getE_Defence() {
        return E_Defence;
    }
    int getE_Speed() {
        return E_Speed;
    }

private:
    int E_HP;
    int E_Attack;
    int E_Defence;
    int E_Speed;
    int E_RewardExp;
};

