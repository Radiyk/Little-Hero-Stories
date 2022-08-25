using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMeshPatrol : MonoBehaviour
{
    Vector3 target;
    Vector3 backTarget;

    private Transform player;
    private NavMeshAgent agent;
    
    private float normalSpeed = 1.5F;
    private float dist;
    public float distanceAttack;

    public Transform[] movePoints;
	private int pointsIndex;

    bool distanceBreak = true;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        StartDestination();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);

        if (dist <= distanceAttack)
        {
            agent.SetDestination(player.position);
        }
        if (dist >= distanceAttack)
        {
            distanceBreak = true;
            BackDestination();
        }
         if (Vector3.Distance(transform.position, target) < 2)
        {
            IteratePointsIndex();
            StartCoroutine(UpdateDestination());
        }
        
    }

    void StartDestination()
    {
            target = movePoints[pointsIndex].position;
            agent.SetDestination(target);
            agent.speed = normalSpeed;
    }


    void BackDestination()
    {
        
        if (distanceBreak == true)
        {
           
            backTarget = movePoints[pointsIndex].position;
            agent.SetDestination(backTarget);
            distanceBreak = false;
        }
    }

    void IteratePointsIndex()
    {
        pointsIndex++;
        if (pointsIndex == movePoints.Length)
        {
            pointsIndex = 0;
        }
    }

        IEnumerator UpdateDestination() 
    {
        agent.speed = 0;
        yield return new WaitForSeconds(4f);
        StartDestination();

    }
}
