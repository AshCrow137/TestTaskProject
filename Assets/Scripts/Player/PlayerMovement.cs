using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vspeed = 10;
    
    public static float hspeed;

    public float speedMultiplier = 1.5f;

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
        StartCoroutine(ChangeSpeed());
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

    private IEnumerator ChangeSpeed()
    {
        while(true)
        {
            yield return new WaitForSeconds(15);
            vspeed = vspeed * speedMultiplier;
            Debug.Log("Change speed");

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
