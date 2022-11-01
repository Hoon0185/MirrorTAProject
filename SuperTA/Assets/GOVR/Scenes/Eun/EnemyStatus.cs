using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    protected int hp;
    public int EnemyHP = 1;

    public int GetHp() { return hp; }

    public void SetInfo(int hp)
    {
        this.hp = hp;
    }

    private void Start()
    {
        SetInfo(EnemyHP);
    }
}
