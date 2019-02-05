using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildeffect : MonoBehaviour {

    public GameObject BuildEffect;
    // Use this for initialization
    private void Awake()
    {
        StartCoroutine(spawn());
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator spawn()
    {
        GameObject effect = (GameObject)Instantiate(BuildEffect, transform.position, transform.rotation);
        yield return new WaitForSeconds(3);
        Destroy(effect);
    }
    
}
