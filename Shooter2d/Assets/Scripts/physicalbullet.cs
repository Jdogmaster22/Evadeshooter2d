using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicalbullet : MonoBehaviour {

    public int damage = 50;
    private Health h;
    public string tags;
    public GameObject impactEffect;
    public bool Die;
    public bool EnemyCollider;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == tags)
        {
            Debug.Log("Hey");
            h = other.GetComponent<Health>();

            if (h != null)
            {
                h.ammount = damage;
            }
            if (gameObject.tag == "Player")
            {
                DestroyProjectile();
            }
            if (EnemyCollider == true)
            {
                if (gameObject.layer == other.gameObject.layer)
                {
                    DestroyProjectile();
                }
            }
        }
    }
    private void Start()
    {
        if (Die == true)
        {
            StartCoroutine(die());
        }
    }
    void DestroyProjectile()
    {
        GameObject effectsIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectsIns, 2f);
        Destroy(gameObject);
    }

    IEnumerator die()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    

}
