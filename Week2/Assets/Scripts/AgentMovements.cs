using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovements : MonoBehaviour
{
	public Transform agentDestination, agentSpawn;
	private NavMeshAgent agent;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();

		agent.destination = agentDestination.position;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Destination")
		{
			agent.destination = agentSpawn.position;
			gameObject.tag = "Despawn";
		}

		if (gameObject.tag == "Despawn")
		{
			if (other.tag == "SpawnPoint")
			{
				Destroy(gameObject);
			}
			
		}
	}
}
