using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private PlayerMovement movement;

    private void Start()
    {
        movement = PlayerMovement.Instance;
    }
    private void FixedUpdate()

    {
        if (movement)
        {


            //Привязываем скорость камеры к горизонтальной скорости заспавненного персонажа, чтобы при изменении его скорости, менялась и скорость камеры
            transform.position = new Vector3(movement.transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            movement = PlayerMovement.Instance;
        }
    }
}
