using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float vspeed = 10;
    [SerializeField]
    private float speedMultiplier = 1.5f;

    private float hspeed;

    private Rigidbody rb;
    private bool bStartMoving = false;

    static PlayerMovement instance;
    public static PlayerMovement Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();
        StartCoroutine(ChangeSpeed());
        StaticsVariables.gameTime = 0;
        hspeed = StaticsVariables.horizontalSpeed;
       
    }

    private void FixedUpdate()
    {
        if(bStartMoving)
        {
            MoveHorizontal();
            if (Input.GetKey(KeyCode.W))
            {
                MoveVertical(1);
            }
            else
            {

                MoveVertical(-0.7f);
            }
            StaticsVariables.gameTime += Time.deltaTime;
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                bStartMoving = true;
                StaticsVariables.bIsGameStarted = bStartMoving;
            }
        }

        
    }

    private IEnumerator ChangeSpeed()
    {
        while(true)
        {
            if(bStartMoving)                    //Ждем пока игрок не нажмет кнопку вверх, после чего запускаем таймер на 15 секунд
            {
                yield return new WaitForSeconds(15);
                vspeed = vspeed * speedMultiplier;

                Debug.Log("Change speed");
            }
            else
            {
                yield return new WaitForSeconds(0.1f); //Если кнопка не нажата, обнуляем таймер не изменяя скорости
            }
            

        }
    }
        


    private void MoveHorizontal()
    {
        rb.velocity = new Vector3(hspeed * Time.deltaTime, 0, 0);

    }

    private void MoveVertical(float direction)
    {

            Vector3 vertical = new Vector3(0, vspeed  * direction, 0);
            rb.AddForce(vertical, ForceMode.VelocityChange);
    }
}
