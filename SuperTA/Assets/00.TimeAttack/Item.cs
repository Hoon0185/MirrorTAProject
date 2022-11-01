using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//플레이어가 HP Item을 먹으면 일정 HP 향상
public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Debug.Log("아이템 충돌");
            HpBar.Instance.CurHp = +HpBar.Instance.HpItem;
            Debug.Log("현재 HP: " + HpBar.Instance.CurHp);

            Destroy(other.gameObject);
        }
    }

}
