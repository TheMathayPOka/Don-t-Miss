using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float time1;
    public float time2;
    public float minX;
    public float maxX;
    public float minY;
    public float maxy;

    public GameObject enemy;

    void start(){
        time1 = time2;
    }

    void Update(){
        time1-=Time.deltaTime;
        Vector2 pos = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxy));

        if(time1<=0){
            Instantiate(enemy,pos,Quaternion.identity);
            time1 = time2;
        }
    }
}
