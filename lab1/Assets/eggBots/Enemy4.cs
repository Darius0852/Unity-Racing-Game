using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy4 : MonoBehaviour
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
        if (player.position.z > 400)
        {
            agent.SetDestination(player.position);
        }
    }
}
