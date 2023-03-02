using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPoints : MonoBehaviour
{

    public GameObject[] enemySpawner;
    public Transform[] destinationPoint;
    private Transform spawnPoint;


	private void Start()
	{
        spawnPoint = transform;
	}
	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
		{
            GameObject soldier = Instantiate(enemySpawner[0], transform.position, Quaternion.identity) as GameObject;
            soldier.GetComponent<AgentMovements>().agentDestination = destinationPoint[0];
            soldier.GetComponent<AgentMovements>().agentSpawn = spawnPoint;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject soldier = Instantiate(enemySpawner[1], transform.position, Quaternion.identity) as GameObject;
            soldier.GetComponent<AgentMovements>().agentDestination = destinationPoint[1];
            soldier.GetComponent<AgentMovements>().agentSpawn = spawnPoint;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject soldier = Instantiate(enemySpawner[2], transform.position, Quaternion.identity) as GameObject;
            soldier.GetComponent<AgentMovements>().agentDestination = destinationPoint[2];
            soldier.GetComponent<AgentMovements>().agentSpawn = spawnPoint;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameObject soldier = Instantiate(enemySpawner[3], transform.position, Quaternion.identity) as GameObject;
            soldier.GetComponent<AgentMovements>().agentDestination = destinationPoint[3];
            soldier.GetComponent<AgentMovements>().agentSpawn = spawnPoint;
        }
    }
}
