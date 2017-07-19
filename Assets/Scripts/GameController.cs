using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject spawnObject;
    public Vector3 spawnValues;

	// Use this for initialization
	void Start () {
        SpawnWaves();
	}
	
	void SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnValues.x, spawnValues.x),
            spawnValues.y,
            spawnValues.z);
        Instantiate(spawnObject, spawnPosition, Quaternion.identity);

    }
}
