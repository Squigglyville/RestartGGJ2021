﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AdultBehaviour : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public float secondsUntilMove;
    public float secondsStandingStill;
    

    // Start is called before the first frame update
    void Start()
    {
        GoToRandomNavPoint();
        navAgent = GetComponent<NavMeshAgent>();
        secondsUntilMove = (Random.Range(3, 10));
    }

    void GoToRandomNavPoint()
    {
        int randomNavPointIndex = Random.Range(0, References.navpoints.Count);
        navAgent.destination = References.navpoints[randomNavPointIndex].transform.position;
        Vector3 LookAtPosition = navAgent.transform.position;
        transform.LookAt(LookAtPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (navAgent.remainingDistance < 1)
        {
            
            secondsStandingStill += Time.deltaTime;
            if(secondsStandingStill >= secondsUntilMove)
            {
                GoToRandomNavPoint();
                secondsStandingStill = 0;
                secondsUntilMove = (Random.Range(3, 10));
            }
        }
    }
}
