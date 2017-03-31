using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public GameObject[] obstaclesEasy;
    public GameObject[] obstaclesMedium;
    public GameObject[] obstacleHard;

    public float spawnSpeed;
    private Vector3 spawnLocation;
    private Vector3 centerScreen;

    public bool playerAlive;

	// Use this for initialization
	void Start () {
        playerAlive = true;
        StartCoroutine(SpawnObstacles());
	}

    IEnumerator SpawnObstacles()
    {
        while (playerAlive)
        {
            yield return new WaitForSeconds(GameManager.wallSpawnDelay);
            CreateObstacle();
        }
    }

    void CreateObstacle()
    {
        Instantiate(obstaclesEasy[Random.Range(0, obstaclesEasy.Length-1)]);
    }

}
