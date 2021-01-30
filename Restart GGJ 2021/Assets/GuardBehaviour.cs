using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardBehaviour : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public List<NavPoint> pointPatrol;
    public int pointPatrolIndex;

    // Start is called before the first frame update
    void Start()
    {
        GoToNextNavPoint();
        pointPatrolIndex = 0;
    }

    void GoToNextNavPoint()
    {

        navAgent.destination = pointPatrol[pointPatrolIndex].transform.position;
    }

    /*
    void ChasePlayer()
    {
     navAgent.destination = References.thePlayer.transform.position;
     
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (navAgent.remainingDistance < 1)
        {
            GoToNextNavPoint();
            pointPatrolIndex += 1;
        }

        if (pointPatrolIndex >= pointPatrol.Count)
        {
            pointPatrolIndex = 0;
        }
        
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        GameObject theirGameObject = collision.gameObject;

        if(theirGameObject.GetComponent<Player>() != null)
        {
            ChasePlayer();
        }
        
    }
    */
}
