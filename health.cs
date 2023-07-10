using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float life = 100f;

    void Update(){
        if(life <= 0){
            Destroy(gameObject);
        }
    }

    public void damage(float dam){
        life = life - dam;

    }
}
