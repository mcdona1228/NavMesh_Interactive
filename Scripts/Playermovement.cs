using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Playermovement : MonoBehaviour
{
    public float forwardForce = 0f;
    public Rigidbody rb;
    int jumpcount = 0;
    public int MaxJumps = 2;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Fixed update because physics
    void Update()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 1000 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }
        if (Input.GetKeyDown("e"))
        {
            if (jumpcount> 0)
            {
                rb.AddForce(0, 320 * Time.deltaTime, 0, ForceMode.VelocityChange);
                jumpcount--;
            }
            
        }
       
    }
}
