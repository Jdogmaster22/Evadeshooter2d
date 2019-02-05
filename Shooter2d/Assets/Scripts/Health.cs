using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public float startHelath = 100f;
    public float ammount;
    private float health;
    public string tags;
    public GameObject impactEffect;

    public Image healthBar;
    // Use th    public Image healthBar;is for initialization
    void Start () {
       //GameObject image = GameObject.FindGameObjectWithTag("HealthBar");
        //healthBar = image.GetComponent<Image>();
        health = startHelath;
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == tags)
        {

            Debug.Log("Hello");
            TakeDamage();
        }
    }

    // Update is called once per frame
    void Update () {
        if (healthBar == null){
            GameObject image = GameObject.FindGameObjectWithTag("HealthBar");
            healthBar = image.GetComponent<Image>();
        }
        if(gameObject.tag == "Player")
        {
            healthBar.fillAmount = health / startHelath;
            if (health <= 100)
            {
                health += .01f;
            }
        }
	}
    public void TakeDamage()//(float amount)
    {
        health -= ammount;//amount;

        healthBar.fillAmount = health / startHelath;

        if (health <= 0)
        {
            GameObject effectsIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectsIns, 2f);
            Destroy(gameObject);
        }
    }
}
