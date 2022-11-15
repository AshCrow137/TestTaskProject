using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vspeed;
    
    public float hspeed;

    private Rigidbody rb;


    static PlayerMovement instance;
    public static PlayerMovement Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
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
