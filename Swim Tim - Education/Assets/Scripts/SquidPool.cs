using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidPool : MonoBehaviour {

	public GameObject squidPrefab;
	public float spawnRate = 10f;

	private float lastSpawnTime;
	private GameObject squidPre;
	private Vector2 squidPoolPosition = new Vector2 (20f, -3f);	// Position where the pool initially spawns

	private float spawnXPosition = 20f;
	private float spawnYPosition;

	private float minYPosition = -3f;		//-2.2f
	private float maxYPosition = 4f;		//3.40f

	private int currentSquid = 0;



	// Use this for initialization
	void Start () {

		lastSpawnTime = 0f;

		squidPre = (GameObject)Instantiate (squidPrefab, squidPoolPosition, Quaternion.identity);

	}

	// Update is called once per frame
	void Update () {

		if (GameControl.instance.questionTime == true) {
			spawnRate = 15f;
			lastSpawnTime = lastSpawnTime;

		}

		if (GameControl.instance.questionTime == false) {
			lastSpawnTime += Time.deltaTime;
		}

		if (GameControl.instance.gameOver == false && lastSpawnTime >= spawnRate && GameControl.instance.questionTime == false) 
		{

			spawnRate = 10f;
			lastSpawnTime = 0f;
			spawnYPosition = Random.Range (minYPosition, maxYPosition);
			squidPre.transform.position = new Vector2 (spawnXPosition, spawnYPosition);
			currentSquid++;
		}

	}
}
