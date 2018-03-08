using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PufferFish : MonoBehaviour {

	Vector2 initialSize = new Vector2 (0.16f, 0.16f);
	Vector2 initialPosition = new Vector2 (11f, EnemyControl.enemyPositionY);

	private float initialWidth = 0.16f;
	private float initialHeight = 0.16f;

	private float increaseSize = 1f;
	private float direction = -1f;
	private float speed = 3f;
	private float timPosition;

	private float maxWidth = 0.62f; 
	private float maxheight = 0.62f;


	// Use this for initialization
	void Start () {
		
		transform.localScale = initialSize;
		transform.position = initialPosition;

	}
	
	// Update is called once per frame
	void Update () {

		timPosition = Tim.timCurrentPosition.y;
		
		if (GameControl.instance.gameOver == true || GameControl.instance.questionTime == true) {
			
			}

		else if (GameControl.instance.gameOver == false || GameControl.instance.questionTime == false) { 

			if (EnemyControl.spawnPufferfish == true) {

				if(transform.position.y < -5f){
					RespawnPufferFish ();
				}

				MovePufferFish ();

				if (transform.position.x <= -15f) {
					RespawnPufferFish ();
				}
			} else if (EnemyControl.spawnPufferfish == false) {
				MoveToPool ();
			}

		}

	}

	void MovePufferFish(){

		transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);

		if (transform.position.x > -15f && transform.position.x < 0f) {
			
			increaseSize = increaseSize += Time.deltaTime * 2;
			transform.localScale = initialSize * increaseSize;
			speed = 3.5f;
		}

	}

	void RespawnPufferFish(){

		transform.position = new Vector2 (11f, timPosition);
		speed = 3f;
		increaseSize = 1f;
		transform.localScale = initialSize;
	}

	void MoveToPool(){

		transform.position = new Vector2 (11f, EnemyControl.enemyPositionY);
	}

}
