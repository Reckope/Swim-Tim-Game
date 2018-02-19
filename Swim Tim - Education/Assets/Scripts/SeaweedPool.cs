using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaweedPool : MonoBehaviour {

	public GameObject seaweedPrefab;
	public float spawnRate = 16f;
	//public float seaweedMin = -1f;
	//public float seaweedMax = 3.5f;


	private float lastSpawnTime;
	private GameObject seaweedPre;
	private Vector2 seaweedPoolPosition = new Vector2 (-12f, -17f);	// Position where the pool spawns
	private float spawnXPosition = 30f;
	private float spawnYPosition = -3.28f;
	private int currentSeaweed = 0;


	void Start () {

		lastSpawnTime = 0f;

		seaweedPre = (GameObject)Instantiate (seaweedPrefab, seaweedPoolPosition, Quaternion.identity);

	}


	void Update () {

		lastSpawnTime += Time.deltaTime;
		if (GameControl.instance.gameOver == false && lastSpawnTime >= spawnRate) 
		{
			lastSpawnTime = 0f;
			seaweedPre.transform.position = new Vector2 (spawnXPosition, spawnYPosition);
			currentSeaweed++;
		}



	}
}

