using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPoints : MonoBehaviour
{

    public GameObject enemySpawner;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
		{
            Instantiate(enemySpawner, transform.position, Quaternion.identity);
		}

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(enemySpawner, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(enemySpawner, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Instantiate(enemySpawner, transform.position, Quaternion.identity);
        }
    }
}
