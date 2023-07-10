using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public Player isGrounded;

    void Start()
    {
        isGrounded = GetComponentInParent<Player>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ground" || collision.tag == "aground")
        {
            isGrounded.isgrounded();
        }
        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "ground" || collision.tag == "aground")
        {
            isGrounded.notgrounded();
        }
    }

}
