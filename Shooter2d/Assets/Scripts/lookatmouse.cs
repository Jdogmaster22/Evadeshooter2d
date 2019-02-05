using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatmouse : MonoBehaviour {

    public float health;
    // Use this for initialization
    void Update()
    {
        faceMouse();
    }

    // Update is called once per frame

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }
}
