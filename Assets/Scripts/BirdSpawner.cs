using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour {

    public GameObject Bird;
    public float SpawnTime;

    private float currentSpawnTime;
	// Use this for initialization
	void Start () {
        currentSpawnTime = SpawnTime;
	}
	
	// Update is called once per frame
	void Update () {
        currentSpawnTime -= Time.deltaTime;
        if (currentSpawnTime < 0) {
            currentSpawnTime = SpawnTime;
            SpawnBird();
        }
	}



    private void SpawnBird()
    {
        Vector3 position = new Vector3(12, Random.Range(-3.5f, 3.5f), 1);
        Instantiate(Bird, position, Quaternion.identity);
    }
}
