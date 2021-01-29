using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardBehaviour : MonoBehaviour
{
    public NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        GoToRandomNavPoint();
    }

    void GoToRandomNavPoint()
    {
        int randomNavPointIndex = Random.Range(0, References.navpoints.Count);
        navAgent.destination = References.navpoints[randomNavPointIndex].transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (navAgent.remainingDistance < 1)
        {
            GoToRandomNavPoint();
        }
    }
}
