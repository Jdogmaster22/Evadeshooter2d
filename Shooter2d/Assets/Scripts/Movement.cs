using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float Speed;

	// Use this for initialization
	void Start () {
        Speed = 3f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        float axisX = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(axisX, axisY) * Time.deltaTime * Speed, Space.World);
	}
}
