using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroygameobject : MonoBehaviour {

    private Health h;
    public int damage = 50;
    public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void DestroyProjectile()
    {
        GameObject effectsIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectsIns, 2f);
        Destroy(gameObject);
    }
}
