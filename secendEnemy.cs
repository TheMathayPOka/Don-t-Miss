using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secendEnemy : MonoBehaviour
{
    public GameObject[] spwanpoints;

    public float time1;
    float time2;
    public float speed;
    public float dam;
    public float health = 100;
    public GameObject Man;
    public GameObject ded;
    void Start()
    {
        time2 = time1;
        spwanpoints = GameObject.FindGameObjectsWithTag("point");
        Man = GameObject.FindGameObjectWithTag("man");
    }

    void Update()
    {
        time2 -= Time.deltaTime;
        int index = Random.Range(0,spwanpoints.Length);
        Transform randompoint = spwanpoints[index].transform;
        
        if(time2<0){
            
            transform.position = Vector3.Lerp(transform.position, randompoint.position, speed);
            time2 = time1;
        }

        dam = Random.Range(20,60);

        if(health<=0){
            Destroy(gameObject);
            Man.GetComponent<manager>().plus();
            Instantiate(ded, transform.position, Quaternion.identity);
        }
    }

    void OnCollisionEnter2D(Collision2D collider){
        if(collider.collider.tag == "Player"){
            collider.gameObject.GetComponent<health>().damage(dam);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bul")
        {
            health = health - dam;
            Destroy(collision.gameObject);
 
        }
    }
}
