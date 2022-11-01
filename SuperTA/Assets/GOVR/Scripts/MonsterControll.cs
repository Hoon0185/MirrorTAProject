using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Mirror;

public class MonsterControll : NetworkBehaviour
{

    NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            Debug.Log(collision + "와 접촉하였습니다");
            RpcDamageMonster();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("플레이어 감지");
        if (!nav.enabled) nav.enabled = true;
        if(other.tag == "Player")
        {
            nav.SetDestination(other.transform.position);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            nav.enabled = false;
        }
    }

    [ClientRpc]
    void RpcDamageMonster()
    {
        NetworkServer.Destroy(this.gameObject);
        Debug.Log("몬스터가 파괴되었습니다");
    }

}
