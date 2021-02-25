using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2 : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z > 200 && player.position.z < 300)
        {
            agent.SetDestination(player.position);
        }
    }
}
