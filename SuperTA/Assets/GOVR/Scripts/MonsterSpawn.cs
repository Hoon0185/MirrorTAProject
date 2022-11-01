using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Mirror;

public class MonsterSpawn : NetworkBehaviour
{

    public GameObject monsterPerfab;
    public float spawnRange = 10;
    public float spawnHeight = 5;

    float currentTime = 0;
    private void Start()
    {
        if (!isServer)
            FindObjectOfType<NetworkManager>().StartHost();
    }
    void Update()
    {
        //if (!isServer) return;
        if (isServer) 
        TimeCount();
    }

    
    //[Command]
    void TimeCount()
    {
        currentTime += Time.deltaTime;
        Debug.Log("함수 실행");
        
        if(currentTime >= 3)
        {
            RpcMonsterSpawn();
            currentTime = 0;
        }
        
    }


    [ClientRpc]
    void RpcMonsterSpawn()
    {
        Vector3 vector3 =
            new Vector3
            (Random.Range(-spawnRange, spawnRange), spawnHeight, Random.Range(-spawnRange, spawnRange));

        GameObject spawnMonster = Instantiate(monsterPerfab, vector3, Quaternion.identity);

        NetworkServer.Spawn(spawnMonster);

    }
}
