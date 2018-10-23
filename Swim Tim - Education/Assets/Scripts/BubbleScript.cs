using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour {

	//Vector2 initialPositionCrab = new Vector2 (3f, -7f); // - 3.8
	Vector2 currentPosition;

	private float speed = 4f;
	private float direction = -1f;

	private bool dirRight = true;
	private float sideSpeed = 4.0f;


	public float MinX = -4.50f;
	public float MaxX = 4.50f;

	public float YPoint = -7f;
	public float randomY;
	public float randomX;
	public static float upwardDirection = 1f;

	// Use this for initialization
	void Start () {

		//transform.position = initialPositionCrab;
		randomX = Random.Range (MinX, MaxX);

		transform.position = new Vector2 (randomX, YPoint);
		upwardDirection = 1f;

		SpriteRenderer spRend = transform.GetComponent<SpriteRenderer>();
		Color col = spRend.color;
		col.a = 0.5f;
		spRend.color = col;
		
	}
	
	// Update is called once per frame
	void Update () {

		MoveCrab ();
		MoveLeftToRight ();
		if (transform.position.y > 7f && transform.position.x < 8f) {
			RespawnCrab ();
		}

	}

	void MoveCrab(){

		transform.Translate (0, upwardDirection*speed*Time.deltaTime * 1, 0);

		if (transform.position.y > 7f && transform.position.x < 8f) {
			RespawnCrab ();
		}

	}

	void RespawnCrab(){

		randomX = Random.Range (MinX, MaxX);
		sideSpeed = Random.Range (4.5f, 2f);

		transform.position = new Vector2 (randomX, -7f);
		upwardDirection = 1f;

	}

	void MoveLeftToRight(){

		if (dirRight)
			transform.Translate (Vector2.right * sideSpeed * Time.deltaTime);
		else
			transform.Translate (-Vector2.right * sideSpeed * Time.deltaTime);

		if(transform.position.x >= (randomX + 0.6f)) {
			dirRight = false;
		}

		if(transform.position.x <= (randomX - 0.6f)) {
			dirRight = true;
		}
	}
}
