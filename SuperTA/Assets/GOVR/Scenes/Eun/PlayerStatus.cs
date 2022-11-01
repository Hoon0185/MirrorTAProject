using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected int hp;
    protected int Maxhp;
    protected int attack;


    public int GetHp() { return hp; }
    public int GetMaxHp() { return Maxhp; }
    public int GetAttack() { return attack; }

    public void SetInfo(int hp, int attack)
    {
        this.hp = hp;
        this.attack = attack;
    }

    private void Awake()
    {
        Maxhp = hp;
    }
}
