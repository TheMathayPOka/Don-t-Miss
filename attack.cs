using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
   public Transform Player;
   public float speed;
   public float dam;
 

   void Start(){
    Player = GameObject.FindGameObjectWithTag("Player").transform;

   }

   void FixedUpdate(){

    transform.position += Vector3.MoveTowards(transform.position,Player.position,speed);

    dam = Random.Range(5,12);
   }



   void OnTriggerEnter2D(Collider2D other){
    if(other.tag=="Player"){
        other.GetComponent<health>().damage(dam);
    }
    if(other.tag == "ground"){
        Destroy(gameObject);
    }
   }

}
