using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPool : MonoBehaviour {

	public GameObject foodPrefab;
	public float spawnRate = 10f;

	private float lastSpawnTime;
	private GameObject foodPre;
	private Vector2 foodPoolPosition = new Vector2 (20f, 0f);	// Position where the pool initially spawns

	private float spawnXPosition = 20f;
	private float spawnYPosition;

	private float minYPosition = -2.2f;
	private float maxYPosition = 3.40f;

	private int currentFood = 0;



	// Use this for initialization
	void Start () {

		lastSpawnTime = 0f;

		foodPre = (GameObject)Instantiate (foodPrefab, foodPoolPosition, Quaternion.identity);
		
	}
	
	// Update is called once per frame
	void Update () {

		lastSpawnTime += Time.deltaTime;

		if (GameControl.instance.gameOver == false && lastSpawnTime >= spawnRate && GameControl.instance.questionTime == false) 
		{
			lastSpawnTime = 0f;
			spawnYPosition = Random.Range (minYPosition, maxYPosition);
			foodPre.transform.position = new Vector2 (spawnXPosition, spawnYPosition);
			currentFood++;
		}
		
	}
}
