using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        playerStatus = FindObjectOfType<PlayerStatus>();
        healthBar = GetComponent<Slider>();
    }

    private void Start()
    {
        healthBar.maxValue = playerStatus.GetMaxHp();
        healthBar.value = playerStatus.GetHp();
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }

}
