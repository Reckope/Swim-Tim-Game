using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatEnemy : MonoBehaviour {


	public float spawnRate = -15f;

	private float spawnXPosition = 25f;
	private float spawnYPosition;


	private float minYPosition = -3f;		//-2.2f
	private float maxYPosition = 3.5f;		//3.40f

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (transform.position.x <= spawnRate) {
			SpawnEnemy ();
		}

	}

	void SpawnEnemy(){

		transform.position = new Vector2 (spawnXPosition, spawnYPosition);

	}
		
}
