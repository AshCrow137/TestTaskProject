using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnDelay = 15;

    private void Awake()
    {
        StartCoroutine(StartSpawnObstacle());
    }

    private IEnumerator StartSpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            SpawnObstacle(obstacle);
        }
        
    }
 

    private void SpawnObstacle(GameObject obstacle)
    {
        Debug.Log("Spawn obstacle");
        float posx = transform.position.x;
        float posy = Random.Range(-5, 6);
        Instantiate(obstacle, new Vector3(posx, posy, 0), Quaternion.identity);


    }
}
