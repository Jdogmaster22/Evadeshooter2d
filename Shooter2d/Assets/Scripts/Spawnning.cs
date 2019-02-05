using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnning : MonoBehaviour
{
    public float number = 3f;
    public List<prefab> prefabs = new List<prefab>();
    public List<GameObject> spawnPoints = new List<GameObject>();
    private float timeBtwShots;
    public float startTimeBtwShots;


    // Update is called once per frame
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
       // InvokeRepeating("random", 5f, number);

    }
    private void Update()
    {
        spawn();
    }

    public void random()
    {
        for (int i = 0; i < prefabs.Count; i++)
        {

            if (Random.value * 100 < prefabs[i].spawnChance)
            {

                Instantiate(prefabs[i].prefabObject, spawnPoints[Random.Range(0, spawnPoints.Count)].transform.position, Quaternion.identity);
                Debug.Log(prefabs[i].prefabObject.name + " has spawned in the location: " + prefabs[i].prefabObject.transform.position);
                Debug.Log("spawn chance is: " + prefabs[i].spawnChance + "%");

            }
        }
    }

    public void spawn()
    {
        timeBtwShots -= Time.deltaTime;

        if (timeBtwShots <= 0)
        {
            for (int i = 0; i < prefabs.Count; i++)
            {

                if (Random.value * 100 < prefabs[i].spawnChance)
                {
                    Instantiate(prefabs[i].prefabObject, spawnPoints[Random.Range(0, spawnPoints.Count)].transform.position, Quaternion.identity);
                    Debug.Log(prefabs[i].prefabObject.name + " has spawned in the location: " + prefabs[i].prefabObject.transform.position);
                    Debug.Log("spawn chance is: " + prefabs[i].spawnChance + "%");
                }
            }
            timeBtwShots = startTimeBtwShots;
        }
    }



    [System.Serializable]
    public class prefab
    {
    public GameObject prefabObject;
    public float spawnChance;
    public ParticleSystem buildEffect;
    }
}
