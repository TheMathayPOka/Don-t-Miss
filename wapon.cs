using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wapon : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public GameObject muzzle;
    public Transform tr;

    public float time1;
    public float time2;
    public float rooff;



    void Start()
    {
        time1 = time2;
    }

    void Update()
    {
        time1 -= Time.deltaTime;
 
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float ritZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, ritZ + offset);

        if (Input.GetMouseButton(0) && time1 < 0)
        {
            Instantiate(bullet, tr.position, Quaternion.identity);
            Instantiate(muzzle, tr.position, Quaternion.Euler(0f, 0f, ritZ + rooff));
            time1 = time2;
        }

    }
}
