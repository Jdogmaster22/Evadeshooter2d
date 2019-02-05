using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject bullet;
    public Transform firePosition;

    private float timeBtwShots;
    public float startTimeBtwShots;
	// Use this for initialization
	void Start () {
        timeBtwShots = startTimeBtwShots;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            timeBtwShots -= Time.deltaTime;

            if (timeBtwShots <= 0)
            {
                Instantiate(bullet, firePosition.position, firePosition.rotation);
                timeBtwShots = startTimeBtwShots;
            }
           // else
           // {
            //   timeBtwShots -= Time.deltaTime;
            //}
        }
    }

}
