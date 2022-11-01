using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetNavFucShin : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(player.position);
    }

    
    
}
