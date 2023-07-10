using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform tr;
    public Rigidbody2D rb;
    public bool grounded;

    public float speed;
    public float jumpSpeed;
  
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0));
        }

        if (Input.GetKeyDown(KeyCode.W) && grounded == true|| Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rb.AddForce(new Vector2(0, jumpSpeed));
        }

    }

    public void isgrounded()
    {
        grounded = true;
    }

    public void notgrounded()
    {
        grounded = false;
    }

}
