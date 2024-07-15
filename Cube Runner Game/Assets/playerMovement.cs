using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour

{
    public Rigidbody rb;
    public float force = 2000f;
    public float sideforce = 500f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, force * Time.deltaTime);

        if (Input.GetKey("d"))
        {   
            rb.AddForce(sideforce * Time.deltaTime, 0 ,0 ,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {   
            rb.AddForce(-sideforce * Time.deltaTime, 0 ,0 ,ForceMode.VelocityChange);
        }
    }
}
