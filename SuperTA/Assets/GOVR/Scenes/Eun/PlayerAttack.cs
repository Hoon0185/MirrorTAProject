using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int playerHP = 10;
    public int playerAttack = 1;
    PlayerStatus playerStatus;
    EnemyStatus enemyStatus;

    public HealthBar healthBar;

    private void Awake()
    {
        playerStatus = GetComponent<PlayerStatus>();
        playerStatus.SetInfo(playerHP, playerAttack);

        enemyStatus = GetComponent<EnemyStatus>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            int currentHP = playerStatus.GetHp();
            currentHP--;
            int currentEnemyHP = enemyStatus.GetHp();
            currentEnemyHP -= playerStatus.GetAttack();

            healthBar.SetHealth(currentHP);

            Debug.Log($"플레이어 HP : {currentHP}");
            Debug.Log($"몬스터 HP : {currentEnemyHP}");
        }
    }
}
