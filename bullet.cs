using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public Vector2 target;
    public float offset;

    public GameObject enemy;

    void Start()
    {
        //target = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float ritZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, ritZ + offset);
    }

    void FixedUpdate()
    {

        transform.position += transform.right * speed * Time.deltaTime;

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "ground"){
            Instantiate(enemy,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
