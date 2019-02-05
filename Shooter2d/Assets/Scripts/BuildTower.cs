using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTower : MonoBehaviour {

    public GameObject player;
    public GameObject Upgrade;
	// Use this for initialization
	void Start () {
        //player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Build()
    {
       //Upgrade.transform.position = player.transform.position;
        //Destroy(player);
        Instantiate(Upgrade.gameObject, transform.position, transform.rotation);
        Destroy(this.gameObject);
       // player = this.gameObject;
    }

}
