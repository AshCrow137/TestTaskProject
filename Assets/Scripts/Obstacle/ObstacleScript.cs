using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
   
    private void Awake()
    {
        Destroy(this.gameObject,10);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Debug.Log("Collide");
            Destroy(other.gameObject);
            SceneController.Instance.LoadGameOverScene("GameOverMenu");
        }
    }
}
