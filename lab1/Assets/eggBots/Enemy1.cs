﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour
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
        
            agent.SetDestination(player.position);

    }
}
