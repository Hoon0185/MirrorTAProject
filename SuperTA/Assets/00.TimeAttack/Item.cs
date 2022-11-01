using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�÷��̾ HP Item�� ������ ���� HP ���
public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Debug.Log("������ �浹");
            HpBar.Instance.CurHp = +HpBar.Instance.HpItem;
            Debug.Log("���� HP: " + HpBar.Instance.CurHp);

            Destroy(other.gameObject);
        }
    }

}
