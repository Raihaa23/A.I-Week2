using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class PatrolPoints : MonoBehaviour
{
    public Transform[] patrolPoints;
    public Transform player;
    public NavMeshAgent agent;
    private int destinationPoints;
    public float stoppingDistance = 0.5f;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        GoToNextPoint();
    }

    public void GoToNextPoint()
    {
        if (patrolPoints.Length == 0)
        {
            return;
        }

        agent.destination = patrolPoints[destinationPoints].position;


        destinationPoints = (destinationPoints + 1) % patrolPoints.Length;
    }

    // Update is called once per frame
    void Update()
    {

        float searchRadius = Vector3.Distance(transform.position, player.position);
		if (!agent.pathPending && agent.remainingDistance < stoppingDistance)
		{
            GoToNextPoint();
		}

		if (radius > searchRadius)
		{
            agent.destination = player.position;
		}
    }

	private void OnDrawGizmos()
	{
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position, radius);
	}
}
