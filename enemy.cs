using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health = 100f;
    public float dam;
    public float playerdam = 10f;
    public float time1;
    public float time2;
    public GameObject[] spwanpoints;
    public GameObject attack;
    public GameObject ded;
    public GameObject Man;

    // Start is called before the first frame update
    void Start()
    {
        time2 = time1;
        spwanpoints = GameObject.FindGameObjectsWithTag("point");
        Man = GameObject.FindGameObjectWithTag("man");
    }

    // Update is called once per frame
    void Update()
    {
        time2 -= Time.deltaTime;
        int index = Random.Range(0,spwanpoints.Length - 1);
        Transform randompoint = spwanpoints[index].transform;
        
        if(time2<0){
            
            transform.position = randompoint.position;
            time2 = time1;
        }
        dam = Random.Range(20, 40);

        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(ded, transform.position, Quaternion.identity);
            Man.GetComponent<manager>().plus();

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

    void OnCollisionEnter2D(Collision2D other){
        if(other.collider.tag == "Player"){
            other.gameObject.GetComponent<health>().damage(dam);
            Destroy(gameObject);
        }
    }
            

}
 
