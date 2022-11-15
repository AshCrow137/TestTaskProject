using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private float spawnDelay = 15;

    private void Awake()
    {
        StartCoroutine(StartSpawnObstacle());
    }

    private IEnumerator StartSpawnObstacle()
    {
        while (true)
        {
           //Если игра не начата, не запускаем триггер спавна препядствий
            if(StaticsVariables.bIsGameStarted)
            {
                SpawnObstacle(obstacle);
                yield return new WaitForSeconds(spawnDelay); 
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
        
    }
 

    private void SpawnObstacle(GameObject obstacle)
    {
       
        float posx = transform.position.x;
        float posy = Random.Range(- 5,  6);
        Instantiate(obstacle, new Vector3(posx, posy, 0), Quaternion.identity);


    }
}
